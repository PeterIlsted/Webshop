using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace Webshop._1.Model
{
    public class Order
    {
        public CustomerInfo Customer;
        public int OrderID { get; set; }
        public List<OrderItem> Items = new List<OrderItem> { };
        public double TotalPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }
        public int Points { get; set; }


        public void AddItems(Item item)
        {
            OrderItem orderItem = new OrderItem(item, 1);
            Items.Add(orderItem);
            TotalPrice = CalcPrice();
            Points = CalcPoints(TotalPrice);
        }

        public void deleteItems(int itemID)
        {
            foreach(OrderItem item in Items)
            {
                if (item.ItemID == itemID)
                {
                    Items.Remove(item);
                    break;
                }
            }
            TotalPrice = CalcPrice();
            Points = CalcPoints(TotalPrice);
        }
        public double CalcPrice()
        {
            double price = 0;
            foreach (OrderItem item in Items)
            {
                price += item.Total;
            }
            return price;
        }
    }
}
