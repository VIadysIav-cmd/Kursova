
using System.Data;


namespace NET.Services
{
    public interface IDatabaseService
    {
        DataTable ExecuteQuery(string query, Dictionary<string, object>? parameters = null);
    }
}
