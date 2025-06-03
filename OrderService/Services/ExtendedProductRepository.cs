using Microsoft.Data.SqlClient;
using OrderService.Interfaces;
using OrderService.Models;

namespace OrderService.Services
{
    public class ExtendedProductRepository : IProductRepository
    {
        private readonly string _connectionString;

        public ExtendedProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Product? FindPart(string id)
        {
            const string query = "SELECT PartID AS ID,Parts.Name AS PartName, Price, Quantity FROM Parts inner join Categories on Parts.CategoryID = Categories.CategoryID WHERE PartID = @Id";

            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Product(
                    Convert.ToInt32(reader["ID"]),
                    reader["PartName"].ToString(),
                    Convert.ToDecimal(reader["Price"]),
                    Convert.ToInt32(reader["Quantity"])
                );
            }

            return null;
        }

        public void UpdateProductQuantity(int productId, int newQuantity)
        {
            const string query = "UPDATE Parts SET Quantity = @Quantity WHERE PartID = @Id";

            using SqlConnection connection = new SqlConnection(_connectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Quantity", newQuantity);
            command.Parameters.AddWithValue("@Id", productId);

            connection.Open();
            command.ExecuteNonQuery();
        }


    }
}
