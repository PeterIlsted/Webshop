using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Model;
using Webshop.MVVM;

namespace Webshop.Model
{
    public class CustomerViewModel : ViewModelBase
    {
        private ObservableCollection<CustomerInfo> _customers {  get; set; }
        private CustomerInfo _customer;
        public PointSystem Points { get; set; }
        public CustomerInfo Customer 
        {
            get { return _customer; }
            set 
            { 
                _customer = value;
                OnPropertyChanged();
            }
        }
        private void Login()
        {
            //Metode til at logge ind.
            Points = Customer.system;
        }
        public void NewCustomer()
        {
            Customer = new CustomerInfo();
            Points = Customer.system;
            _customers.Add(Customer);
        }
        public string GetMP()
        {
            return Customer.GetMP();
        }
        public string GetPP() { return Customer.GetPP(); }
        public Bank GetBank() { return Customer.GetBank(); }

    }
}
