using BarcodeService.Services;
using BarcodeService.Models;

namespace BarcodeService
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Получение строки подключения
            string connectionString = ConnectionStringProvider.Instance.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("Строка подключения пустая.");
                return;
            }
            var services = new ServiceManager(connectionString);
            Application.Run(new InputCodeForm(services));

        }
    }
}