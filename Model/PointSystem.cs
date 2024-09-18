using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class PointSystem
    {
        public List<Point> PointList { get; set; }
        private int _pointSum;
        public int PointSum 
        { 
            get { return _pointSum; } 
            set
            {
                if (value < 0)
                    _pointSum -= value;
                else
                    _pointSum += value;
            }
        }

        public void AddPoint(int OrderID, int Points)
        {
            Point NewPoints = new Point(OrderID, Points);
            PointList.Add(NewPoints);
            PointSum = Points;
        }

        
    }
}