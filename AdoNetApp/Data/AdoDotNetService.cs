
using System.Data;
using Microsoft.Data.SqlClient;

namespace AdoNetApp.Data
{
    public class AdoNetAppService
    {
        string connectionString = "Server=localhost,1433;Database=AdoNetAppDb;User Id=sa;Password=pps@Password123;TrustServerCertificate=True;MultipleActiveResultSets=true";

        public void Read()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "SELECT * FROM Products";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow dr = dataTable.Rows[i];
                    int id = Convert.ToInt32(dr["Id"]);
                    string name = dr["Name"].ToString();
                    decimal price = Convert.ToDecimal(dr["Price"]);
                    int quantity = Convert.ToInt32(dr["Quantity"]);
                    Console.WriteLine($"No:{id} - Name:{name} - Price:{price} - Qty:{quantity}");
                }

            }
        }

        public void Create()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "INSERT INTO Products (Name, Price, Quantity) VALUES ('MacBook', 1500, 100)";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int result = command.ExecuteNonQuery();

                Console.WriteLine(result > 0 ? "Product created successfully." : "Failed to create product.");

            }
        }

        public void Update()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "UPDATE Products SET Price = 1400 WHERE Name = 'MacBook'";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int result = command.ExecuteNonQuery();

                Console.WriteLine(result > 0 ? "Product updated successfully." : "Failed to update product.");
            }
        }

        public void Delete()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM Products WHERE Name = 'MacBook'";
                SqlCommand command = new SqlCommand(query, sqlConnection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine(result > 0 ? "Product deleted successfully." : "Failed to delete product.");
            }
        }
    }
    
}