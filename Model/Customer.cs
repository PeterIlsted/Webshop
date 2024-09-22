using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public int Points { get; set; }
        public int UserID { get; set; }
        public Customer(int customerID, 
                        string firstName, 
                        string lastName, 
                        string phone,
                        string email,
                        string adress, 
                        int postalCode,
                        int points,
                        int userID)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            Adress = adress;
            PostalCode = postalCode;
            City = City;
            Points = points;
            UserID = userID;
        }
        public Customer(int customerID,
                        string firstName,
                        string lastName,
                        string phone,
                        string email,
                        string adress,
                        int postalCode,
                        int userID) : this(0, 
                                            firstName, 
                                            lastName, 
                                            phone, 
                                            email, 
                                            adress, 
                                            postalCode, 
                                            0, 
                                            0) 
        {  }
        public Customer() : this(0, null, null, null, null, null, 0, 0)
        {
            
        }
    }
}
