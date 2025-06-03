namespace BarcodeService.Models
{
    public class Part
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }

        public Part(string name, decimal price, int quantity, string category)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
