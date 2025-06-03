
using System.Data;


namespace AdminService.Interfaces
{
    public interface IDatabaseService
    {
        DataTable ExecuteQuery(string query, Dictionary<string, object>? parameters = null);
        public void ExecuteNonQuery(string query, Dictionary<string, object>? parameters = null);
    }
}
