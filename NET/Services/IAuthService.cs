

namespace NET.Services
{
    public interface IAuthService
    {
        bool CheckWorker(string login, string password);
    }
}
