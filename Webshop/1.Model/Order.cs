using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Item> Items { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }

    }
}
