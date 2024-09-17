using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    internal class CustomerRepo : IRepository<CustomerInfo>
    {
        List<CustomerInfo> Customers = new List<CustomerInfo>();
        public void AddCustomer(CustomerInfo customer) { Customers.Add(customer); }
        
        public void DeleteCustomer(CustomerInfo Customer) {  Customers.Remove(Customer); }
        public void AddOrder(CustomerInfo Customer, int OrderId, int Points) { Customer.AddOrder(OrderId, Points); }

        public IEnumerable<CustomerInfo> GetAllTypes()
        {
            return Customers;
        }

        public CustomerInfo GetByID(int ID)
        {
            return Customers.FirstOrDefault(C => C.CustomerID == ID);
        }

        public void AddType(CustomerInfo type)
        {
            throw new NotImplementedException();
        }

        public void DeleteType(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateType(CustomerInfo type)
        {
            throw new NotImplementedException();
        }
    }
}
