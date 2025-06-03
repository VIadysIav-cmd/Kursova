using OrderService.Models;

namespace OrderService
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            // Получение строки подключения
            string productConnection = MultiConnectionProvider.Instance.Products;
            string orderConnection = MultiConnectionProvider.Instance.Orders;

            if (string.IsNullOrEmpty(productConnection) || string.IsNullOrEmpty(orderConnection))
            {
                Console.WriteLine("Строка подключения пустая.");
                return;
            }
            var services = new ServiceManager(productConnection, orderConnection);

            Application.Run(new OrderForm(services));
        }
    }
}