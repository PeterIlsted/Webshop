using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int EarnedPoints { get; set; }
        public int SpentPoints { get; set; }
        public int InfoID { get; set; }
        public int CustomerID { get; set; }
        public Order(int orderID, 
                    DateTime orderDate, 
                    int earnedPoints, 
                    int spentPoints, 
                    int infoID, 
                    int customerID)
        {
            OrderID = orderID;
            OrderDate = orderDate;
            EarnedPoints = earnedPoints;
            SpentPoints = spentPoints;
            InfoID = infoID;
            CustomerID = customerID;
        }
        public Order(DateTime orderDate, 
                    int earnedPoints, 
                    int spentPoints) : this(0, 
                                    orderDate, 
                                    earnedPoints, 
                                    spentPoints, 
                                    0, 
                                    0) { }
        public Order() : this(DateTime.MinValue, 0, 0) { }
    }
}
