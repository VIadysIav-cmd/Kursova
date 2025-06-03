using CatalogService.Interfaces;
using CatalogService.Models;

namespace CatalogService.Forms
{
    public partial class GoodsReceptionForm : Form
    {
        private readonly IGoodsSender _goodsSender;
        public GoodsReceptionForm(IGoodsSender goodsSender)
        {
            _goodsSender = goodsSender;
            InitializeComponent();
        }

        private void GoodsReceptionForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Supplier", "Постачальник");
            dataGridView1.Columns.Add("Name", "Назва");
            dataGridView1.Columns.Add("Quantity", "Кількість");


            // Задаём ширину каждому столбцу (делим ширину DataGridView на 3)
            int columnWidth = (int)(dataGridView1.ClientSize.Width / 3.25);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = columnWidth;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveEmptyRowsFromDataGridView(dataGridView1);

                var items = ExtractItemsFromGrid();
                if (items == null || !items.Any())
                {
                    MessageBox.Show("Пустий список", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    _goodsSender.SendGoods(items);
                    MessageBox.Show("Дані успішно відправлені на сервер.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при відправці: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveEmptyRowsFromDataGridView(DataGridView dgv)
        {
            for (int i = dgv.Rows.Count - 1; i >= 0; i--)
            {
                var row = dgv.Rows[i];
                bool isEmpty = true;

                // Пропускаем строку добавления (новую строку)
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        isEmpty = false;
                        break;
                    }
                }

                if (isEmpty)
                {
                    dgv.Rows.RemoveAt(i);
                }
            }
        }

        private List<GoodsItem> ExtractItemsFromGrid()
        {
            var items = new List<GoodsItem>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                var supplier = row.Cells["Supplier"].Value?.ToString();
                var name = row.Cells["Name"].Value?.ToString();
                var quantityStr = row.Cells["Quantity"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(supplier) || string.IsNullOrWhiteSpace(name) || !int.TryParse(quantityStr, out int quantity))
                {
                    throw new Exception("Усі поля мають бути заповнені коректно.");
                }

                items.Add(new GoodsItem
                {
                    Supplier = supplier,
                    Name = name,
                    Quantity = quantity
                });
            }

            return items;
        }
    }
}

