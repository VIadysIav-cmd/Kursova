using OrderService.Models;

namespace OrderService.Interfaces
{
    public interface IOrderFormService
    {
        void PlaceOrder(List<Product> basketItems, decimal totalAmount);
    }
}
