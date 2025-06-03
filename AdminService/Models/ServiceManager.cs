using AdminService.Interfaces;
using AdminService.Services;

namespace AdminService.Models
{
    public class ServiceManager
    {
        public IDatabaseService dbProduct { get; }

        public IDatabaseService dbWorker { get; }
        public IAuthService Auth { get; }

        public ProductQueryBuiler ProductQuery {  get; }

        public WorkerQueryBuilder WorkerQuery { get; }

        public SupplierQueryBuilder SupplierQuery { get; }

        public MainQueryBuilder MainQuery { get; }

        public GoodsReceiverService Receiver { get; }

        public ServiceManager(string partconnectionString, string userconnectionString, int port, string ip)
        {
            MainQuery = new MainQueryBuilder();
            ProductQuery = new ProductQueryBuiler();
            WorkerQuery = new WorkerQueryBuilder();
            SupplierQuery = new SupplierQueryBuilder();

            dbProduct = new DatabaseService(partconnectionString);
            dbWorker = new DatabaseService(userconnectionString);
            Auth = new AuthService(dbWorker);
            Receiver = new GoodsReceiverService(ip,port);
        }
    }
}
