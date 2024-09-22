using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Webshop.Model;
using Webshop.MVVM;
using Webshop.Repository;

namespace Webshop.Model
{
    public class OrderViewModel : ViewModelBase
    {
        ObservableCollection<OrderItem> Basket { get; set; }
        private OrderItem _item;
        OrderItem SelectedItem
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }
        public double TotalPrice { get; private set; }
        public int Points { get; private set; }
        public int OrderID { get; private set; }
    }
    
}
