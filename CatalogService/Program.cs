using CatalogService.Models;

namespace CatalogService
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string partConnection = MultiConnectionProvider.Instance.CatalogDb;
            //string userConnection = MultiConnectionProvider.Instance.WorkerDb;
            //var partDb = new DatabaseService(partConnection);
            //var authDb = new DatabaseService(userConnection);
            //var authService = new AuthService(authDb);
            var services = new ServiceManager(MultiConnectionProvider.Instance.CatalogDb, MultiConnectionProvider.Instance.WorkerDb, "192.168.0.143", 5000);
            Application.Run(new CatalogForm(services));
        }
    }
}