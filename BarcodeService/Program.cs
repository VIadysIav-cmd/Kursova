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

            // ��������� ������ �����������
            string connectionString = ConnectionStringProvider.Instance.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                Console.WriteLine("������ ����������� ������.");
                return;
            }
            var services = new ServiceManager(connectionString);
            Application.Run(new InputCodeForm(services));

        }
    }
}