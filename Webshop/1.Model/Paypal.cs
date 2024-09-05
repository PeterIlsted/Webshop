using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    public class PayPal : PaymentInfo
    {
        public string Email { get; set; }

        public PayPal(string email)
        {
            Email = email;
        }

        // Override abstrakt metode fra PaymentInfo
        public override string GetInfo()
        {
            return $"PayPal Email: {Email}";
        }
    }
}
