using NET.Services;

namespace NET
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string partConnection = @"Server=VLAD\MSSQLSERVER02;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True;";
            string userConnection = @"Server=VLAD\MSSQLSERVER02;Initial Catalog=UsersDB;Integrated Security=True;TrustServerCertificate=True;";
            var partDb = new DatabaseService(partConnection);
            var authDb = new DatabaseService(userConnection);
            var authService = new AuthService(authDb);

            Application.Run(new Catalog(partDb, authService));
        }
    }
}