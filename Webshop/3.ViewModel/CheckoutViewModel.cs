using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop._1.Model;

namespace Webshop._3.ViewModel
{
    internal class CheckoutViewModel
    {
        private readonly IRepository<Order> repository;
        private readonly IRepository<CustomerInfo> customer;
        
        public CustomerInfo Customer;
        public Order Order {  get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        private PayPal PP { get; set; }
        private MobilePay MP { get; set; }
        private Bank Bank { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public void NewUser()
        {
            Customer = new CustomerInfo(FirstName, LastName, StreetName, PostalCode, CityName, PhoneNumber);
            if(PP != null) { Customer.AddPP(PP); }
            else if(MP!= null) { Customer.AddMP(MP); } 
            else if(Bank!= null) { Customer.AddBank(Bank); }
            Customer.NewUser(UserName, Password);
            //method to add user to repo in model layer.
        }
        public void Payment() 
        {
            int ID = repository.AddType(Order);
            Customer.AddOrder(ID, Order.Points);
            ID = Customer.GetID();
            customer.UpdateType();
            
        }
        public CheckoutViewModel( CustomerInfo customer) { Customer = customer; }
        public CheckoutViewModel() : this(null) { }


    }
}
