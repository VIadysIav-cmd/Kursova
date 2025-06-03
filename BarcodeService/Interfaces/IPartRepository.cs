
using BarcodeService.Models;

namespace BarcodeService.Interfaces
{
    public interface IPartRepository
    {
        Part? FindPartByBarcode(string barcode);
    }
}
