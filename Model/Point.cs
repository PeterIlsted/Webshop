using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Point
    {
        public int OrderId { get; }
        public int Points { get; }
        public Point(int ID, int Point)
        {
            OrderId = ID;
            Points = Point;
        }
    }
}
