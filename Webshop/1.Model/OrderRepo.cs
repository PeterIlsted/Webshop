using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Webshop._1.Model;

namespace Webshop._3.ViewModel
{
    internal class OrderRepo : IRepository<Order>
    {
        public List<Order> Orders {  get; set; }
        int _orderCount = 0;
        public int OrderCount
        { 
            get 
            { 
                _orderCount++;
                return _orderCount;
            } 
        }

        public IEnumerable<Order> GetAllTypes()
        {
            return Orders;
        }

        public Order GetByID(int ID)
        {
            return Orders.FirstOrDefault(i => i.OrderID == ID);
        }

        public int AddType(Order type)
        {
            type.OrderID = OrderCount;
            Orders.Add(type);
            return type.OrderID;
        }

        public void DeleteType(int ID)
        {
            Orders.Remove(GetByID(ID);
        }

        public void UpdateType(Order type)
        {
            Order order = GetByID(type.OrderID);
            int index = Orders.IndexOf(order);
            if (index != -1) { Orders[index] = type; }
            else { Orders.Add(type); }
        }
    }
}
