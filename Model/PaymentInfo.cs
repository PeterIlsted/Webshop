using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    internal class PaymentInfo
    {
        public string PayPal { get; set; }
        public string MobilePay { get; set; }
        public string Bank { get; set; }
        public string AccNr { get; set; }
        public string RegNr { get; set; }
        public PaymentInfo(string payPal, 
                           string mobilePay, 
                           string bank, 
                           string accNr, 
                           string regNr)
        {
            PayPal = payPal;
            MobilePay = mobilePay;
            Bank = bank;
            AccNr = accNr;
            RegNr = regNr;
        }
        public PaymentInfo(string payPal, 
                           string mobilePay) : this(payPal, 
                                                    mobilePay, 
                                                    null, 
                                                    null, 
                                                    null){ }
        public PaymentInfo(string bank, 
                           string accNr, 
                           string regNr) : this(null, 
                                                null, 
                                                bank, 
                                                accNr, 
                                                regNr) { }
    }
}
