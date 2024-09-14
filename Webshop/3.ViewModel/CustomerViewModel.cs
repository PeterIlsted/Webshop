using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop._1.Model;
using Webshop.MVVM;

namespace Webshop._3.ViewModel
{
    internal class CustomerViewModel : ViewModelBase
    {
        private ObservableCollection<CustomerInfo> _customers {  get; set; }
        private CustomerInfo _customer;
        CustomerInfo Customer 
        {
            get { return _customer; }
            set 
            { 
                _customer = value;
                OnPropertyChanged();
            }
        }
        private CustomerInfo Login()
        {
            return Customer;
        }
        public void NewCustomer()
        {
            Customer = new CustomerInfo();
            _customers.Add(Customer);
        }

    }
}
