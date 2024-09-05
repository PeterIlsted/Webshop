using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class PointSystem
    {
        public List<int> PointList { get; set; }
        public int PointSum
        {
        }

        public void AddPoint(int points)
        {
            PointList.Add(points);
        }

        public int GetSum()
        {
            return PointSum;
        }
    }
}