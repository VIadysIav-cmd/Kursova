using AdminService.Forms;
using AdminService.Models;
using System.ComponentModel;


namespace AdminService
{
    public partial class MainForm : Form
    {

        public List<string> ReceivedMessages { get; } = new();
        private readonly ServiceManager _services;
        private bool _receiverStarted = false;
        private BindingList<GoodsItem> _goodsBindingList = new();

        public MainForm(ServiceManager services)
        {
            _services = services;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormHelper.SetupNew(InvoicesDataGridView, _goodsBindingList);
        }

        private void WorkersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new WorkerForm(_services.dbWorker, _services.WorkerQuery);  
            form.Location = this.Location;
            FormHelper.OpenCenteredForm(form);
        }

        private void SuppliersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new SupplierForm(_services.dbProduct, _services.SupplierQuery);    
            form.Location = this.Location;
            FormHelper.OpenCenteredForm(form);
        }

        private async void InvoicesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            await _services.Receiver.FetchGoodsAsync(_goodsBindingList, this);
        }

        private void SendParts_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.RemoveEmptyRowsFromDataGridView(InvoicesDataGridView);

                if (!_goodsBindingList?.Any() ?? true)
                {
                    MessageBox.Show("Список накладних порожній. Немає що оновлювати.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Группируем товары по названию
                var grouped = _goodsBindingList
                    .GroupBy(g => g.Name)
                    .Select(g => new
                    {
                        Name = g.Key,
                        TotalQuantity = g.Sum(i => i.Quantity)
                    });

                // Получаем SQL-запрос
                string query = _services.MainQuery.UpdateQuantityQuery();

                foreach (var item in grouped)
                {
                    var parameters = new Dictionary<string, object>
                    {
                        { "@Name", item.Name },
                        { "@Quantity", item.TotalQuantity }
                    };

                    _services.dbProduct.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Кількість товарів успішно оновлена.", "Успіх");
                
                InvoicesDataGridView.Rows.Clear();
                _goodsBindingList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new PartForm(_services.dbProduct , _services.ProductQuery);
            form.Location = this.Location;
            FormHelper.OpenCenteredForm(form); 
        }
    }
}
