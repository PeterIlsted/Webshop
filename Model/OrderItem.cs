using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class OrderItem : Item
    {
        //public Item BasketItem { get; set; }
        public int Count 
        {
            get { return Count; }
            set 
            { 
                Count = value;
                Total = CalcPrice();
            } 
        }
        public double Total { get; set; }
        public double CalcPrice()
        {
            return Price * Count;
        }
        public OrderItem(Item Item, int Count) 
        {
            this.Count = Count;
        }
        public OrderItem(Item Item) :this(Item, 1) 
        {
            this.ItemID = Item.ItemID;
            this.Name = Item.Name;
            this.Description = Item.Description;
            this.Category = Item.Category;
            this.FilePath = Item.FilePath;
            this.Price = Item.Price;
        }
        public OrderItem() :this(null) { }
    }
}
