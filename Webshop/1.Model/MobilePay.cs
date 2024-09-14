using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class MobilePay
    {
        public int Number { get; set; }

        public MobilePay(int number)
        {
            Number = number;
        }

        public string GetInfo()
        {
            return $"MobilePay Number: {Number}";
        }
        public void SetInfo(int number) { Number = number; }
    }
}