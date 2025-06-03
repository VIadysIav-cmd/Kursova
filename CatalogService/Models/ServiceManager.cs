using CatalogService.Interfaces;
using CatalogService.Services;

namespace CatalogService.Models
{
    public class ServiceManager
    {
        public IDatabaseService Database { get; }

        public IDatabaseService IsWorker { get; }
        public IAuthService Auth { get; }

        public IGoodsSender Sender { get; }
        public ServiceManager(string partconnectionString, string userconnectionString, string serverIp, int port)
        {
            Database = new DatabaseService(partconnectionString);
            IsWorker = new DatabaseService(userconnectionString);
            Auth = new AuthService(IsWorker);
            Sender = new NetworkGoodsSender(serverIp, port);
        }
    }
}
