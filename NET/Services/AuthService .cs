using System.Security.Cryptography;
using System.Text;

namespace NET.Services
{
    public class AuthService : IAuthService
    {
        private readonly IDatabaseService _db;

        public AuthService(IDatabaseService db)
        {
            _db = db;
        }

        public bool CheckWorker(string login, string password)
        {
            string query = @"SELECT COUNT(*) FROM Users 
                         WHERE Username COLLATE SQL_Latin1_General_CP1_CI_AS = @Login 
                         AND PasswordHash = @Password";

            var parameters = new Dictionary<string, object>
        {
            { "@Login", login.Trim() },
            { "@Password", ComputeSha256Hash(password) }
        };

            var result = _db.ExecuteQuery(query, parameters);
            return Convert.ToInt32(result.Rows[0][0]) > 0;
        }

        private string ComputeSha256Hash(string rawData)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData.Trim()));
            return string.Concat(bytes.Select(b => b.ToString("x2")));
        }
    }
}
