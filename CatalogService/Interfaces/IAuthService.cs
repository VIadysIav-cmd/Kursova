

namespace CatalogService.Interfaces
{
    public interface IAuthService
    {
        bool CheckWorker(string login, string password);
    }
}
