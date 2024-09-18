using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class PayPal
    {
        public string Email { get; set; }

        public PayPal(string email)
        {
            Email = email;
        }

        // Override abstrakt metode fra PaymentInfo
        public string GetInfo()
        {
            return $"PayPal Email: {Email}";
        }
        public void SetPP(string value) { Email = value; }
    }
}
