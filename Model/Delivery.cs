using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class Delivery
    {
        public DateTime DeliveryDate { get; set; }
        public int OrderID { get; set; }
        public Delivery(DateTime deliveryDate, int orderID) 
        {
            DeliveryDate = deliveryDate;
            OrderID = orderID;
        }
        public Delivery(DateTime deliveryDate) : this(deliveryDate, 0) { }
        public Delivery() : this(DateTime.MinValue) {  }
    }
}
