using CatalogService.Models;
using CatalogService.Forms;
using System.Windows.Forms;

namespace CatalogService
{
    public partial class CatalogForm : Form
    {
        private readonly ServiceManager _services;
        private string _query;
        private bool _isWorkerLoggedIn;

        public CatalogForm(ServiceManager services)
        {
            InitializeComponent();
            _services = services;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            ResetInventoryView();
        }

        private void CatalogForm_Load(object sender, EventArgs e)
        {
            ShowBasicInventory();
        }

        private void LoadData(string query)
        {
            ProductdataGridView.DataSource = _services.Database.ExecuteQuery(query);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text;
            if (string.IsNullOrWhiteSpace(search))
            {
                LoadData(_query); // Если пустой поиск — загружаем текущий режим (админ/обычный)
            }
            else
            {
                LoadData(QueryBuilder.GetSearchNameQuery(search, _isWorkerLoggedIn));
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_services.Auth.CheckWorker(textBoxUsername.Text, textBoxPassword.Text))
            {
                _query = QueryBuilder.GetAdminPartsQuery();
                LoadData(_query);
                _isWorkerLoggedIn = true;
                buttonLogin.Visible = false;
                buttonLogout.Visible = true;
                TabeProductButton.Visible = true;
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                this.ControlBox = true;
            }
            else
            {
                MessageBox.Show("Сотрудник не найден :(");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _query = QueryBuilder.GetPublicPartsQuery();
            LoadData(_query);
            _isWorkerLoggedIn = false;
            buttonLogin.Visible = true;
            buttonLogout.Visible = false;
            TabeProductButton.Visible = false;
            this.ControlBox = false;
        }

        private void ShowBasicInventory()
        {
            _query = QueryBuilder.GetPublicPartsQuery();
            LoadData(_query);
        }

        private void ShowExtendedInventory()
        {
            var query = QueryBuilder.GetAdminPartsQuery();
            LoadData(query);
        }


        private void ResetInventoryView()
        {
            if (_isWorkerLoggedIn)
            {
                ShowExtendedInventory();
            }
            else
            {
                ShowBasicInventory();
            }
            textBoxSearch.Clear();
        }

        private void TabeProductButton_Click(object sender, EventArgs e)
        {
            var form = new GoodsReceptionForm(_services.Sender);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show();
        }
    }
}
