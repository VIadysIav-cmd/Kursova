using Microsoft.Data.SqlClient;
using OrderService.Interfaces;
using OrderService.Models;

namespace OrderService.Services
{
    public class OrderFormService : IOrderFormService
    {
        private readonly string _connectionString;

        public OrderFormService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void PlaceOrder(List<Product> basketItems, decimal totalSum)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // 1. Вставка заказа
                    string insertOrderQuery = "INSERT INTO Orders (OrderSum) VALUES (@sum); SELECT SCOPE_IDENTITY();";
                    int orderId;

                    using (SqlCommand cmd = new SqlCommand(insertOrderQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@sum", totalSum);
                        orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2. Вставка деталей заказа
                    foreach (var product in basketItems)
                    {
                        string insertDetailQuery = @"INSERT INTO OrderDetails (OrderID, PartName, Quantity, Price) 
                                             VALUES (@orderId, @partNane, @quantity, @price)";

                        using (SqlCommand detailCmd = new SqlCommand(insertDetailQuery, connection, transaction))
                        {
                            detailCmd.Parameters.AddWithValue("@orderId", orderId);
                            detailCmd.Parameters.AddWithValue("@partNane", product.Name);
                            detailCmd.Parameters.AddWithValue("@quantity", product.Quantity);
                            detailCmd.Parameters.AddWithValue("@price", product.Price);
                            detailCmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
