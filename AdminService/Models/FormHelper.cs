

using System.ComponentModel;

namespace AdminService.Models
{
    public static class FormHelper
    {
        public static void RemoveEmptyRowsFromDataGridView(DataGridView dgv)
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

        public static void OpenCenteredForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        public static void SetupNew(DataGridView dgv, BindingList<GoodsItem> source)
        {
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

            int colWidth = dgv.Width / 3;

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Постачальник",
                DataPropertyName = "Supplier",
                Width = colWidth
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Товар",
                DataPropertyName = "Name",
                Width = colWidth
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Кількість",
                DataPropertyName = "Quantity",
                Width = colWidth
            });

            dgv.DataSource = source;
        }
    }
}
