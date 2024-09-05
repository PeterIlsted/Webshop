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
        public int OrderID { get; set; }
        public List<Item> Items { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public DateOnly DeliveryDate { get; set; }
        public string DeliveryStatus { get; set; }


        public void AddItems(Item item)
        {
            Items.Add(item);
        }

        public void deleteItems(Item item)
        {
            Items.Remove(item);
        }

        public void CalcPrice()
        {
            double price = 0;
            foreach (Item item in Items)
            {
                price += item.TotalPrice;
            }
            TotalPrice = price;

        }
