
namespace CatalogService.Models
{
    public sealed class MultiConnectionProvider
    {
        private static readonly Lazy<MultiConnectionProvider> _instance =
            new(() => new MultiConnectionProvider());

        public static MultiConnectionProvider Instance => _instance.Value;

        public string CatalogDb { get; }
        public string WorkerDb { get; }

        private MultiConnectionProvider()
        {
            CatalogDb = Read("CatalogConnection.txt");
            WorkerDb = Read("WorkerIDConnection.txt");
        }

        private string Read(string filename)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), filename);
            return File.Exists(path)
                ? File.ReadAllText(path).Trim()
                : throw new FileNotFoundException($"Файл {filename} не знайдено.");
        }
    }
}
