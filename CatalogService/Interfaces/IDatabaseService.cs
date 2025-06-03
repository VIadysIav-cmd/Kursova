
using System.Data;


namespace CatalogService.Interfaces
{
    public interface IDatabaseService
    {
        DataTable ExecuteQuery(string query, Dictionary<string, object>? parameters = null);
    }
}
