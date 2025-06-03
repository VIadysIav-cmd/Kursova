using OrderService.Interfaces;

namespace OrderService.Models
{
    internal class Basket
    {
        private List<Product> _items = new();

        private readonly IProductRepository _repository;

        public Basket(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(Product product, int quantity)
        {
            if (quantity <= 0) throw new ArgumentException("Количество должно быть больше нуля.");
           
            if (product == null)
                throw new InvalidOperationException("Товар не найден в базе данных.");

            var totalRequested = quantity;
            var existingProduct = _items.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
                totalRequested += existingProduct.Quantity;

            if (totalRequested > product.Quantity)
                throw new InvalidOperationException("Недостаточное количество товара в базе данных.");


            if (existingProduct != null)
            {
                existingProduct.Quantity += quantity;
                //_repository.UpdateProductQuantity(existingProduct.Id, product.Quantity-quantity);
            }
            else
            {
                // Создаем копию продукта с введенным количеством
                var productCopy = new Product(
                    product.Id,
                    product.Name,
                    product.Price,
                    quantity
                );
                //_repository.UpdateProductQuantity(product.Id, product.Quantity - quantity);
                _items.Add(productCopy);
            }

           
        }

        public IEnumerable<(int Id, string Name, decimal Price, int Quantity, decimal Total)> GetItems()
        {
            return _items.Select(p => (p.Id, p.Name, p.Price, p.Quantity, p.Price * p.Quantity));
        }

        public List<Product> GetAllItems()
        {
            return new List<Product>(_items);
        }

        public decimal GetTotalSum()
        {
            return _items.Sum(p => p.Price * p.Quantity);
        }

        public int RemoveProduct(Product product, int quantity)
        {
            var existing = _items.FirstOrDefault(p => p.Name == product.Name);
            if (existing == null)
                return 0;

            // Удаляем либо то, что просит кассир, либо максимум из корзины
            int actuallyRemoved = Math.Min(existing.Quantity, quantity);
            existing.Quantity -= actuallyRemoved;

            if (existing.Quantity == 0)
                _items.Remove(existing);

            return actuallyRemoved;
        }

        public void Clear()
        {
            _items.Clear();
        }


    }
}
