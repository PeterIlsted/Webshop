using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class CustomerInfo
    {
        PointSystem system = new PointSystem();
        public MobilePay MP;
        public PayPal PP;
        public Bank Bank;

        public string UserName { get; }
        private string _password { get; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
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
        public void AddPP(PayPal info) { PP = info; }
        public void AddBank(Bank info) { Bank = info; }
        public bool Login(string Password)
        {
            bool Authentification = false;
            if (Password == _password) Authentification = true; ;
            return Authentification;
        }
    }
}
