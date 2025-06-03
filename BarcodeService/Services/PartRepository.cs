using Microsoft.Data.SqlClient;
using BarcodeService.Interfaces;
using BarcodeService.Models;

namespace BarcodeService.Services
{
    public class PartRepository : IPartRepository
    {
        private readonly string _connectionString;

        public PartRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Part? FindPartByBarcode(string barcode)
        {
            const string query = @" SELECT P.Name AS PartName, P.Price, P.Quantity, C.Name AS CategoryName FROM Parts P JOIN Categories C ON C.CategoryID = P.CategoryID WHERE P.Barcode = @Barcode";


            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Barcode", barcode);

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Part(
                    reader["PartName"].ToString(),
                    Convert.ToDecimal(reader["Price"]),
                    Convert.ToInt32(reader["Quantity"]),
                    reader["CategoryName"].ToString()
                );
            }

            return null;
        }
    }
}
