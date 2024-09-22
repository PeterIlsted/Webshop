using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Model;
using Microsoft.Extensions.Configuration; // Til indlæsning af konfigurationsindstillinger fra appsettings.json
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Webshop.MVVM;

namespace Webshop.Repository
{
    public class ItemCatalogue : IRepository<Product> 
    {
        private readonly string _connectionString;
        public ItemCatalogue()
        {
            _connectionString = MVVM.ConfigurationSettings.ConnectionString;
        }
        public void Add(Product entity)
        {
            string query = "INSERT INTO Product (Name, Description, Price, FilePath, Inventory, CatID) VALUES (@Name, @Description, @Price, @FilePath, @Inventory, @CatID)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", entity.Name);
                command.Parameters.AddWithValue("@Description", entity.Description);
                command.Parameters.AddWithValue("@Price", entity.Price);
                command.Parameters.AddWithValue("@FilePath", entity.FilePath);
                command.Parameters.AddWithValue("@Inventory", entity.Inventory);
                command.Parameters.AddWithValue("@CatID", entity.CatID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            string query = "DELETE FROM PRODUCT WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            var Item = new List<Product>();
            string query = "SELECT * FROM Product";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item.Add(new Product
                        {
                            ProductID = (int)reader["ProductID"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                            Price = (decimal)reader["Price"],
                            FilePath = (string)reader["FilePath"],
                            Inventory = (int)reader["Inventory"],
                            CatID = (int)reader["CatID"]
                        });
                    }
                }
            }

            return Item;
        }

        public Product GetById(int id)
        {
            Product product = null;
            string query = "SELECT * FROM PRODUCT WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", id);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product
                        {
                            ProductID = (int)reader["ProductID"],
                            Name = (string)reader["Name"],
                            Description = (string)reader["Description"],
                            Price = (decimal)reader["Price"],
                            FilePath = (string)reader["FilePath"],
                            Inventory = (int)reader["Invenory"],
                            CatID = (int)reader["CatID"]
                        };
                    }
                }
            }

            return product;
        }

        public void Update(Product entity)
        {
            string query = "UPDATE PRODUCT \n " +
                "SET Name = @Name, Description = @Description, " +
                "Price = @Price, FilePath = @FilePath, Inventory = @Inventory, " +
                "CatID = @CatID\n" +
                "WHERE ProductID = @ProductID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductID", entity.ProductID);
                command.Parameters.AddWithValue("@Name", entity.Name);
                command.Parameters.AddWithValue("@Description", entity.Description);
                command.Parameters.AddWithValue("@Price", entity.Price);
                command.Parameters.AddWithValue("@FilePath", entity.FilePath);
                command.Parameters.AddWithValue("@Inventory", entity.Inventory);
                command.Parameters.AddWithValue("@CatID", entity.CatID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
