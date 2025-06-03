using System.Data;
using AdminService.Interfaces;
using AdminService.Models;
using AdminService.Services;

namespace AdminService.Forms
{
    public partial class SupplierForm : Form
    {
        IDatabaseService ProductDB;
        SupplierQueryBuilder queryBuilder;
        private string _query;
        public SupplierForm(IDatabaseService product, SupplierQueryBuilder queries)
        {
            ProductDB = product;
            queryBuilder = queries;
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadProduct_Supplier();
            LoadSuppliers();
            LoadProducts();
        }
        private void LoadProduct_Supplier()
        {
            _query = queryBuilder.GetPublicQuery();
            var table = LoadData(_query);
            dataGridViewProduct_Supplier.DataSource = table;
        }

        enum ContractAction { Add, Delete }

        private void Contract(ContractAction action)
        {
            string productName = comboBoxProductName.Text.Trim();
            string supplierName = comboBoxSupplierName.Text.Trim();
            _query = queryBuilder.SupplierIdByNameQuery();
            var Table = ProductDB.ExecuteQuery(_query, new Dictionary<string, object>
                {
                    { "@SupplierName", supplierName }
                });

            int supplierId = Convert.ToInt32(Table.Rows[0]["SupplierID"]);

            _query = queryBuilder.ProductIdByNameQuery();
            Table = ProductDB.ExecuteQuery(_query, new Dictionary<string, object>
                {
                    { "@ProductName", productName }
                });

            int productId = Convert.ToInt32(Table.Rows[0]["PartID"]);

            _query = queryBuilder.GetCheckContractQuery();
            Table = ProductDB.ExecuteQuery(_query, new Dictionary<string, object>
                {
                    { "@IDpart", productId },
                    { "@IDsupplier", supplierId }
                });
            var insertParams = new Dictionary<string, object>
                    {
                    { "@part", productId },
                    { "@supplier", supplierId }
                    };
            switch (action)
            {
                case ContractAction.Add:
                    if (Table.Rows.Count != 0) { MessageBox.Show("Контракт вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    else
                    {
                        ProductDB.ExecuteNonQuery(queryBuilder.InsertContractQuery(), insertParams);
                        MessageBox.Show("Контракт створено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                break;

                case ContractAction.Delete:
                    if (Table.Rows.Count == 0) { MessageBox.Show("Контракт вже недійсний", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                    else
                    {
                        ProductDB.ExecuteNonQuery(queryBuilder.DeleateContractQuery(), insertParams);
                        MessageBox.Show("Контракт видалено", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
            
        }

        private DataTable LoadData(string query)
        {
            return ProductDB.ExecuteQuery(query);
        }

        private void LoadSuppliers()
        {
            try
            {
                _query = queryBuilder.GetAllCateroryNamesQuery();
                var table = ProductDB.ExecuteQuery(_query); // или просто databaseService.ExecuteQuery(query)



                comboBoxSupplierName.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    comboBoxSupplierName.Items.Add(row["Name"].ToString());
                }

                if (comboBoxSupplierName.Items.Count > 0)
                    comboBoxSupplierName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                _query = queryBuilder.GetAllProductNamesQuery();
                var table = ProductDB.ExecuteQuery(_query); // или просто databaseService.ExecuteQuery(query)

                foreach (DataRow row in table.Rows)
                {
                    comboBoxProductName.Items.Add(row["Name"].ToString());
                }

                if (comboBoxProductName.Items.Count > 0)
                    comboBoxProductName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні: " + ex.Message);
            }
        }

        private void Add_Supplier_Click(object sender, EventArgs e)
        {
            string name = textBoxSupplierName.Text.Trim();
            string phone = textBoxSupplierPhone.Text.Trim();
            string email = textBoxSupplierEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(name) || (string.IsNullOrWhiteSpace(phone) && string.IsNullOrWhiteSpace(email)))
            {
                MessageBox.Show("Не всі ключові поля введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var insertParams = new Dictionary<string, object>
                    {
                    { "@Suppliername", name },
                    { "@Phone", string.IsNullOrWhiteSpace(phone) ? DBNull.Value : phone },
                    { "@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email }
                    };

                ProductDB.ExecuteNonQuery(queryBuilder.InsertSupplierQuery(), insertParams);
                MessageBox.Show("Постачальник створений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
        }

        private void Deleate_Supplier_Click(object sender, EventArgs e)
        {
            string name = comboBoxSupplierName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Не всі ключові поля введені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var insertParams = new Dictionary<string, object>
                    {
                    { "@SupplierName", name }
                    };

                ProductDB.ExecuteNonQuery(queryBuilder.DeleateSupplierQuery(), insertParams);
                MessageBox.Show("Постачальник видалений", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSuppliers();
            }
        }

        private void Add_Contract_Click(object sender, EventArgs e)
        {
            Contract(ContractAction.Add);
            LoadProduct_Supplier();
        }

        private void Deleate_Contract_Click(object sender, EventArgs e)
        {
            Contract(ContractAction.Delete);
            LoadProduct_Supplier();
        }


    }
}
