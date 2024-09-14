using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class Point
    {
        public int OrderId { get; set; }
        public int Points { get; set; }
        public Point(int ID, int Point)
        {
            OrderId = ID;
            Points = Point;
        }
    }
}
