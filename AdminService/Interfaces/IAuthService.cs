

namespace AdminService.Interfaces
{
    public interface IAuthService
    {
        bool CheckAdmin(string login, string password);
    }
}
