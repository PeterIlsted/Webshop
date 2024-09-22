using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Model;
using Microsoft.Extensions.Configuration; // Til indlæsning af konfigurationsindstillinger fra appsettings.json
using System.Data;
using Microsoft.Data.SqlClient; // Til at arbejde med SQL Server via ADO.NET

namespace Webshop.Repository
{
    internal class CustomerRepo : IRepository<Customer>
    {
        private readonly string _connectionString;
        public CustomerRepo(string connectionString) 
        {  
            _connectionString = connectionString; 
        }
        public void Add(Customer entity)
        {
            string query = "INSERT INTO CUSTOMER (FirstName, LastName, Phone, Email, Adress, PostalCode, City, points, CatID)\n" +
                "VALUES (@FirstName, @LastName, @Phone, @Email, @Adress, @PostalCode, @City, @Points, @CatID)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Firstname", entity.FirstName);
                command.Parameters.AddWithValue("@LastName", entity.LastName);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            var Customers = new List<Customer>();
            string query = "SELECT * FROM CUSTOMER";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customers.Add(new Customer
                        {
                            CustomerID = (int)reader["CustomerID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Phone = (string)reader["PhoneNr"],
                            Email = (string)reader["Email"],
                            Adress = (string)reader["Adress"],
                            PostalCode = (int)reader["PostalCode"],
                            City = (string)reader["City"],
                            Points = (int)reader["Points"],
                            UserID = (int)reader["UserId"]
                        });
                    }
                }
            }

            return Customers;
        }

        public Customer GetById(int id)
        {
            Customer customer = null;
            string query = "SELECT * FROM CUSTOMER WHERE CustomerID = @CustomerID";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", id);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        customer = new Customer
                        {
                            CustomerID = (int)reader["CustomerID"],
                            FirstName = (string)reader["FirstName"],
                            LastName = (string)reader["LastName"],
                            Phone = (string)reader["PhoneNr"],
                            Email = (string)reader["Email"],
                            Adress = (string)reader["Adress"],
                            PostalCode = (int)reader["PostalCode"],
                            City = (string)reader["City"],
                            Points = (int)reader["Points"],
                            UserID = (int)reader["UserId"]
                        };
                    }
                }
            }

            return customer;
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
