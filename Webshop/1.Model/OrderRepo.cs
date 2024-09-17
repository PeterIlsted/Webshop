using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._3.ViewModel
{
    internal class OrderRepo
    {
        OrderViewModel SelectedOrder { get; set; }
        List<OrderViewModel> _orders {  get; set; }
        int _orderCount = 0;
        public int OrderCount
        { 
            get 
            { 
                _orderCount++;
                return _orders.Count;
            } 
        }
        public int AddOrder(OrderViewModel order)
        {
            int NewOrderID = OrderCount;
            order.SetID(NewOrderID);
            _orders.Add(order);
            return NewOrderID;
        }
    }
}
