using AdminService.Interfaces;
using AdminService.Services;
using System.Data;
using System.Globalization;

namespace AdminService.Forms
{

    public partial class PartForm : Form
    {

        IDatabaseService ProductDB;
        ProductQueryBuiler queryBuilder;
        private string _query;

        public PartForm(IDatabaseService IsProduct, ProductQueryBuiler queries)
        {
            ProductDB = IsProduct;
            InitializeComponent();
            queryBuilder = queries;
        }

        private void PartForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategory();
        }

        private DataTable LoadData(string query)
        {
            return ProductDB.ExecuteQuery(query);
        }

        private void LoadProducts()
        {
            _query = queryBuilder.GetPublicQuery();
            var table = LoadData(_query);
            dataGridViewProducts.DataSource = table;
        }

        private void LoadCategory()
        {
            try
            {
                _query = queryBuilder.GetAllCateroryNamesQuery();
                var table = ProductDB.ExecuteQuery(_query); // или просто databaseService.ExecuteQuery(query)

                comboBoxCategiries.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    comboBoxCategiries.Items.Add(row["Name"].ToString());
                }

                if (comboBoxCategiries.Items.Count > 0)
                    comboBoxCategiries.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні категорій: " + ex.Message);
            }
        }

        private void findbutton_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadData(_query);
            }
            else
            {
                var Result = LoadData(queryBuilder.SearchCategoryQuery(search));
                if (Result.Rows.Count > 0)
                {
                    dataGridViewProducts.DataSource = Result;
                }
                else
                {
                    Result = LoadData(queryBuilder.ProductSearchLocationQuery(search));
                    if (Result.Rows.Count > 0)
                    {
                        dataGridViewProducts.DataSource = Result;
                    }
                    else
                    {
                        Result = LoadData(queryBuilder.SearchNameQuery(search));
                        if (Result.Rows.Count > 0)
                        {
                            dataGridViewProducts.DataSource = Result;
                        }
                    }
                }
            }
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productname = textBoxProductname.Text.Trim();
                string location = textBoxLocation.Text.Trim();
                string category = comboBoxCategiries.SelectedItem?.ToString();
                string barcode = textBoxBarCode.Text.Trim();

                if (string.IsNullOrEmpty(productname) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(barcode) || string.IsNullOrEmpty(textBoxPrice.Text))
                {
                    MessageBox.Show("Заповніть усі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(textBoxPrice.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out float price))
                {
                    MessageBox.Show("Ціна має бути числом", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем ID категорії за назвою
                var categoryIdQuery = queryBuilder.CategoryIdByNameQuery();
                var categoryTable = ProductDB.ExecuteQuery(categoryIdQuery, new Dictionary<string, object>
                {
                    { "@CategoryName", category }
                });

                if (categoryTable.Rows.Count == 0)
                {
                    MessageBox.Show("Категорія не знайдена в базі", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int categoryId = Convert.ToInt32(categoryTable.Rows[0]["CategoryID"]);

                var insertParams = new Dictionary<string, object>
                {
                    { "@Productname", productname },
                    { "@CategoryName", categoryId },
                    { "@Price", price },
                    { "@Location", location },
                    { "@Barcode", barcode }

                };

                ProductDB.ExecuteNonQuery(queryBuilder.InsertProductQuery(), insertParams);

                MessageBox.Show("Товар успішно доданий!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxProductname.Clear();
                textBoxLocation.Clear();
                comboBoxCategiries.SelectedIndex = 0;
                textBoxBarCode.Clear();
                textBoxPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні товару: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadProducts();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            LoadProducts();
            textBoxSearch.Text = "";
        }

        private void ProductDeleate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Будь ласка, виберіть товар для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dataGridViewProducts.SelectedRows[0];
                string productname = selectedRow.Cells["Товар"].Value?.ToString();
                string barcode = selectedRow.Cells["Штрих"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(productname))
                {
                    MessageBox.Show("Невірн назва товару.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show($"Ви дійсно хочете видалити товар '{productname}'?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;

                var deleteQuery = queryBuilder.DeleteProductQuery();
                ProductDB.ExecuteNonQuery(deleteQuery, new Dictionary<string, object>
                {
                    { "@name", productname },
                    { "@barcode", barcode }
                });

                MessageBox.Show("Товар успішно видалений.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Обновление таблицы после удаления
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні товару: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void clearbutton_MouseEnter(object sender, EventArgs e)
        {
            clearbutton.BackColor = SystemColors.Control;
            clearbutton.ForeColor = Color.Black;
        }

        private void clearbutton_MouseLeave(object sender, EventArgs e)
        {
            clearbutton.BackColor = SystemColors.WindowFrame;
            clearbutton.ForeColor = SystemColors.Control;
        }

        private void findbutton_MouseEnter(object sender, EventArgs e)
        {
            findbutton.BackColor = SystemColors.Control;
            findbutton.ForeColor = Color.Black;
        }

        private void findbutton_MouseLeave(object sender, EventArgs e)
        {
            findbutton.BackColor = SystemColors.Control;
            findbutton.ForeColor = Color.Black;
        }
    }
}
