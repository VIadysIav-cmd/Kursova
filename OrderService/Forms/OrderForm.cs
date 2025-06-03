using Microsoft.Data.SqlClient;
using OrderService.Models;
using System.Globalization;

namespace OrderService
{
    public partial class OrderForm : Form
    {
        private readonly ServiceManager _services;
        private readonly Basket _basket;
        private Product? _currentProduct;
        public OrderForm(ServiceManager services)
        {
            _services = services;
            _basket = new Basket(_services.Update);

            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string barcode = textBox_BarCode.Text?.Trim();
            if (!_services.Validator.Validate(barcode, out var error))
            {
                MessageBox.Show(error);
                return;
            }

            try
            {
                _currentProduct = _services.Repository.FindPart(barcode);
                if (_currentProduct != null)
                    ShowProductDetails(_currentProduct);
                else
                    MessageBox.Show("����� �� ��������.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"������� ��� ������ ������:\n{ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_AddToBasket_Click(object sender, EventArgs e)
        {
            AddToBasket();
          
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            var items = _basket.GetAllItems();
            if (items.Count == 0)
            {
                MessageBox.Show("������� �����!");
                return;
            }

            string text = label_Total.Text.Replace("����� ������:", "").Trim();

            decimal totalSum = decimal.Parse(text, NumberStyles.Currency, CultureInfo.GetCultureInfo("uk-UA"));

            _services.Order.PlaceOrder(_basket.GetAllItems(), totalSum);

            _basket.Clear();
            UpdateBasketView();
            _currentProduct = null;
            label_Name.Text = string.Empty;
            label_Price.Text = string.Empty;
            textBox_Quantity.Text = string.Empty;
            MessageBox.Show("����� ��������.");
        }

        private void button_DeleateFromBasket_Click(object sender, EventArgs e)
        {
            RemoveFromBasket();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {  
                if (e.RowIndex >= 0 && e.RowIndex < BasketDataGridView.Rows.Count)
                {
                    var row = BasketDataGridView.Rows[e.RowIndex];
                    string? name = row.Cells["Name"].Value?.ToString();
                    string? priceStr = row.Cells["Price"].Value?.ToString();

                    if (!string.IsNullOrEmpty(name) && decimal.TryParse(priceStr, out decimal price))
                    {
                        // ���� ����� � ������� �� �����
                        var item = _basket.GetItems().FirstOrDefault(i => i.Name == name);
                        // ���� ����� (������ �� ��������� � �� null, � (null, 0, 0, 0))
                        if (!string.IsNullOrEmpty(item.Name))
                        {
                            // ������ _currentProduct �������
                            _currentProduct = new Product(
                                item.Id, // Id � ���� �� �������� � ������� � ����� �������� 0
                                item.Name,
                                item.Price,
                                item.Quantity
                            );

                            ShowProductDetails(_currentProduct);
                        }
                    }
                }
            
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("�� �������, ��� ������ ������������ �������?", "�������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                foreach (var item in _basket.GetItems())
                {
                    // �������� ����� �� ����� (��� ����� �� Id, ���� �� ����)
                    var productFromDb = _services.Update.FindPart(item.Id.ToString());
                    if (productFromDb != null)
                    {
                        int updatedQuantity = productFromDb.Quantity + item.Quantity;
                        _services.Update.UpdateProductQuantity(productFromDb.Id, updatedQuantity);
                    }
                }


                _basket.Clear();
                UpdateBasketView();
                _currentProduct = null;
                label_Name.Text = string.Empty;
                label_Price.Text = string.Empty;
                textBox_Quantity.Text = string.Empty;
                label_Total.Text = string.Empty;
                MessageBox.Show("������� ������������.");
            }

        }

        private void ShowProductDetails(Product part)
        {
            label_Name.Text = part.Name;
            label_Price.Text = part.Price.ToString("F2");
            textBox_Quantity.Text = "1";

        }

        private void RemoveFromBasket()
        {
            if (_currentProduct == null)
            {
                MessageBox.Show("�������� ����� ��� ��������.");
                return;
            }

            if (int.TryParse(textBox_Quantity.Text, out int quantityToRemove) && quantityToRemove > 0)
            {
                // ?? ��������, ������� ���������� ������� �� �������
                int removedQuantity = _basket.RemoveProduct(_currentProduct, quantityToRemove);

                if (removedQuantity > 0)
                {
                    var dbProduct = _services.Update.FindPart(_currentProduct.Id.ToString());
                    if (dbProduct != null)
                    {
                        int updatedQuantity = dbProduct.Quantity + removedQuantity;
                        _services.Update.UpdateProductQuantity(_currentProduct.Id, updatedQuantity);
                        _currentProduct.Quantity = updatedQuantity;
                    }

                    UpdateBasketView();
                    MessageBox.Show($"����� ����� �� �������!");
                }
                else
                {
                    MessageBox.Show("������ ���������� ��� � �������.");
                }
            }
            else
            {
                MessageBox.Show("������� ���������� ���������� ��� ��������.");
            }
        }

        private void UpdateBasketView()
        {
            var items = _basket.GetItems().ToList();

            // ������� �������� ����� �����������
            BasketDataGridView.Columns.Clear();
            BasketDataGridView.DataSource = null;

            // ��������� ������� �������
            BasketDataGridView.Columns.Add("Name", "��������");
            BasketDataGridView.Columns.Add("Price", "����");
            BasketDataGridView.Columns.Add("Quantity", "����������");
            BasketDataGridView.Columns.Add("Total", "�����");

            // ���������� �������
            foreach (var item in items)
            {
                BasketDataGridView.Rows.Add(item.Name, item.Price, item.Quantity, item.Total);
            }
            UpdateBasketTotal();

        }

        private void AddToBasket()
        {
            if (int.TryParse(textBox_Quantity.Text, out int quantity) && quantity > 0)
            {
                if (_currentProduct == null)
                {
                    MessageBox.Show("����� �� ������. ������� ����� ����� ����������� � �������.");
                    return;
                }

                // �������� ���������� ������ �� ����
                var dbProduct = _services.Update.FindPart(_currentProduct.Id.ToString());

                try
                {
                    // ��������� � �������
                    _basket.AddProduct(dbProduct, quantity);

                    int newDbQuantity = dbProduct.Quantity - quantity;
                    _services.Update.UpdateProductQuantity(dbProduct.Id, newDbQuantity);

                    UpdateBasketView();
                    MessageBox.Show("����� �������� � �������!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ���������� ������: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("������� ���������� ����������.");
            }
        }

        private void UpdateBasketTotal()
        {
            decimal total = _basket.GetTotalSum();
            label_Total.Text = $"����� ������: {total:C}";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
