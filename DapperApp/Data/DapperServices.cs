using Microsoft.Data.SqlClient;

namespace Dapper.Data.DapperServices
{
    public class DapperServices
    {
        string connectionString = "Server=localhost,1433;Database=AdoNetAppDb;User Id=sa;Password=pps@Password123;TrustServerCertificate=True;MultipleActiveResultSets=true";

        public void Read()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Select * from Products";

                var products = sqlConnection.Query<Product>(query).ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"No:{product.Id} - Name:{product.Name} - Price:{product.Price} - Qty:{product.Quantity}");
                }

            }
        }

        public void Create()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Insert into Products (Name, Price, Quantity) Values (@Name, @Price, @Quantity)";

                var parameters = new
                {
                    Name = "AUSU",
                    Price = 1200,
                    Quantity = 50
                };

                int result = sqlConnection.Execute(query, parameters);

                Console.WriteLine(result > 0 ? "Product created successfully." : "Failed to create product.");
            }
        }

        public void Delete()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Delete from Products where Name = @Name";

                var parameters = new
                {
                    Name = "AUSU"
                };

                int result = sqlConnection.Execute(query, parameters);

                Console.WriteLine(result > 0 ? "Product deleted successfully." : "Failed to delete product.");
            }
        }

        public void Update()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "Update Products set Price = @Price where Name = @Name";

                var parameters = new
                {
                    Name = "AUSU",
                    Price = 1100
                };

                int result = sqlConnection.Execute(query, parameters);

                Console.WriteLine(result > 0 ? "Product updated successfully." : "Failed to update product.");
            }
        }
    }
}

