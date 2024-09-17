using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    internal class CustomerRepo : IRepository<CustomerInfo>
    {
        List<CustomerInfo> Customers;
        private int _newID = 0;
        public int NewID 
        {
            get
            {
                _newID++;
                return _newID;
            }
        }

        public IEnumerable<CustomerInfo> GetAllTypes()
        {
            throw new NotImplementedException();
        }

        public CustomerInfo GetByID(int ID)
        {
            return Customers.FirstOrDefault(i => i.CustomerID == ID);
        }

        public int AddType(CustomerInfo type)
        {
            throw new NotImplementedException();
        }

        public void DeleteType(int ID)
        {
            Customers.Remove(GetByID(ID));
        }

        public void UpdateType(CustomerInfo type)
        {
            CustomerInfo item = GetByID(type.CustomerID);
            int index = Customers.IndexOf(item);
            if (index != -1) { Customers[index] = type; }
            else { Customers.Add(type); }
        }
        public CustomerRepo(List<CustomerInfo> list) 
        { 
            Customers = list;
            foreach(CustomerInfo item in Customers)
            {
                if (item.CustomerID > _newID) 
                    item.CustomerID = _newID;
            }
        }
        public CustomerRepo() : this(null) { Customers = new List<CustomerInfo>(); }
    }
}
