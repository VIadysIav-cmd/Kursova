using BarcodeService.Models;


namespace BarcodeService
{
    public partial class PartDetailsForm : Form
    {
        private readonly Part _part;

        private readonly ServiceManager _services;

        public PartDetailsForm(Part part, ServiceManager services)
        {
            InitializeComponent();
            _part = part;
            _services = services;

            DisplayPartDetails();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form = new InputCodeForm(_services)
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location
            };

            form.Show();
            this.Hide();
        }

        private void DisplayPartDetails()
        {
            nameValue.Text = _part.Name;
            priceValue.Text = _part.Price.ToString("0.00");
            quantityValue.Text = _part.Quantity.ToString();
            typeValue.Text = _part.Category;
        }
    }
}
