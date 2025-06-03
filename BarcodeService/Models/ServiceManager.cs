using BarcodeService.Interfaces;
using BarcodeService.Services;


namespace BarcodeService.Models
{
    // Facade 
    public class ServiceManager
    {
        public IPartRepository Repository { get; }
        public IInputValidator Validator { get; }
       
        public ServiceManager(string connectionString)
        {
            // Factory part: створюємо всі сервіси
            Repository = new PartRepository(connectionString);
            Validator = new BasicInputValidator();
        }
    }
}
