using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Bank
    {
        public string BankName { get; set; }
        public string AccNr { get; set; }
        public string Reg { get; set; }

        public Bank(string bankName, string accNr, string reg)
        {
            BankName = bankName;
            AccNr = accNr;
            Reg = reg;
        }

        // Override abstrakt metode fra PaymentInfo
        public string GetInfo()
        {
            return $"Bank: {BankName}, Account Number: {AccNr}, Reg: {Reg}";
        }

        public void SetInfo(string Name, string Acc, string Reg)
        {
            BankName = Name;
            AccNr = Acc;
            this.Reg = Reg;
        }
    }
}