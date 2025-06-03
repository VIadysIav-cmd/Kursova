

namespace BarcodeService.Models
{
    public sealed class ConnectionStringProvider
    {
        private static readonly Lazy<ConnectionStringProvider> _instance =
        new Lazy<ConnectionStringProvider>(() => new ConnectionStringProvider());

        public static ConnectionStringProvider Instance => _instance.Value;

        public string ConnectionString { get; }

        private ConnectionStringProvider()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "ProductConnectionString.txt");
            if (File.Exists(filePath))
                ConnectionString = File.ReadAllText(filePath).Trim();
            else
                throw new FileNotFoundException("Файл з рядком підключення не знайдено.");
        }
    }
}
