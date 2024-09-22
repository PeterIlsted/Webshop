using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class OrderItem
    {
        public int OrderID { get; set; }
        public Product Item {  get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int OrderSum { get; set; }
        public OrderItem(int orderID, 
                        Product item, 
                        int productID, 
                        int quantity, 
                        int orderSum)
        {
            OrderID = orderID;
            Item = item;
            ProductID = productID;
            Quantity = quantity;
            OrderSum = orderSum;
        }
        public OrderItem(Product item, 
                        int productID, 
                        int quantity, 
                        int orderSum) : this(0, 
                                            item, 
                                            0, 
                                            quantity, 
                                            orderSum) { }
        public OrderItem(Product item, int quantity) : this(item, 0, quantity, 0) { }
        public OrderItem() :this(null, 0) { }
    }
}
