

using NET.Services;
using NET.Helpers;


namespace NET
{

    public partial class Catalog : Form
    {
        private readonly IDatabaseService _databaseService;
        private readonly IAuthService _authService;
        private string _query;
        private bool _isWorkerLoggedIn;

        public Catalog(IDatabaseService db, IAuthService auth)
        {
            InitializeComponent();
            _databaseService = db;
            _authService = auth;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _query = QueryBuilder.GetPublicPartsQuery();
            LoadData(_query);

        }

        private void LoadData(string query)
        {
            dataGridView1.DataSource = _databaseService.ExecuteQuery(query);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (_authService.CheckWorker(textBoxUsername.Text, textBoxPassword.Text))
            {
                _query = QueryBuilder.GetAdminPartsQuery();
                LoadData(_query);
                _isWorkerLoggedIn = true;
                buttonLogin.Visible = false;
                buttonLogout.Visible = true;
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
                LoadData(QueryBuilder.GetSearchQuery(search, _isWorkerLoggedIn));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            ResetInventoryView();
        }

        private void ShowBasicInventory()
        {
            var query = QueryBuilder.GetPublicPartsQuery();
            LoadData(query);
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
    }
}
