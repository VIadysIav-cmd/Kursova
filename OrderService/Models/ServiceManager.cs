using OrderService.Interfaces;
using OrderService.Services;


namespace OrderService.Models
{
    // Facade 
    public class ServiceManager
    {
        public IProductRepository Repository { get; }

        public IProductRepository Update { get; }
        public IInputValidator Validator { get; }

        public IOrderFormService Order { get; }

        public ServiceManager(string productConnection, string orderConnection)
        {
            // Factory part: створюємо всі сервіси
            Repository = new ProductRepository(productConnection);
            Update = new ExtendedProductRepository(productConnection);
            Validator = new BasicInputValidator();
            Order = new OrderFormService(orderConnection);
        }
    }
}
