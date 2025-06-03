
using OrderService.Models;

namespace OrderService.Interfaces
{
    public interface IProductRepository
    {
        Product? FindPart(string barcode);

        void UpdateProductQuantity(int productId, int newQuantity);

    }
}
