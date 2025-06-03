using Microsoft.Data.SqlClient;
using BarcodeService.Models;
using System.Windows.Forms;


namespace BarcodeService
{
    public partial class InputCodeForm : Form
    {
        private readonly ServiceManager _services;

        public InputCodeForm(ServiceManager services)
        {
            _services = services;

            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string barcode = textBox1.Text?.Trim();
            if (!_services.Validator.Validate(barcode, out var error))
            {
                MessageBox.Show(error);
                return;
            }

            try
            {
                var part = _services.Repository.FindPartByBarcode(barcode);
                if (part != null)
                    ShowPartDetails(part);
                else
                    MessageBox.Show("Товар не знайдено.");
            }
            catch (SqlException ex)
            {   
                MessageBox.Show($"Помилка при підключенні до бази даних:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невідома помилка: \n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPartDetails(Part part)
        {
            var form = new PartDetailsForm(part, _services);

            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            form.Show();

            this.Hide();
        }
    }
}
