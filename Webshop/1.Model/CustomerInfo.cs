using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class CustomerInfo
    {
        public PointSystem system = new PointSystem();
        public MobilePay MP;
        public PayPal PP;
        public Bank Bank;

        public string UserName { get; private set; }
        private string _password { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public int Phone { get; set; }
        public List<int> Orders { get; set; }
        public void AddOrder(int OrderID, int Points) 
        { 
            Orders.Add(OrderID);
            system.AddPoint(OrderID, Points);
        }
        public int GetPoints() { return system.PointSum; }
        public void AddMP(MobilePay info) { MP = info; }
        public string GetMP() { return MP.GetInfo(); }
        public void AddPP(PayPal info) { PP = info; }
        public string GetPP() { return PP.GetInfo(); }
        public void AddBank(Bank info) { Bank = info; }
        public Bank GetBank() { return Bank; }
        public void NewUser(string userName, string password)
        {
            UserName = userName;
            this._password = password;
        }
        public bool Login(string Password)
        {
            bool Authentification = false;
            if (Password == _password) Authentification = true; ;
            return Authentification;
        }
        public CustomerInfo(string firstName, string lastName, string adress, int postalCode, string city, int phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
            PostalCode = postalCode;
            City = city;
            Phone = phone;
        }
        public CustomerInfo() : this(null, null, null, 0, null, 0) { }
    }
}
