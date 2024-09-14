using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using Webshop._1.Model;
using Webshop.MVVM;

namespace Webshop._3.ViewModel
{
    internal class OrderViewModel : ViewModelBase
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
        public double TotalPrice {  get; private set; }
        public int Points { get; private set; }
        public int OrderID { get; }
        public void AddItem(Item item)
        {
            SelectedItem = new OrderItem(item);
            Basket.Add(SelectedItem);
        }
        public void AddItem(Item item, int Amount)
        {
            SelectedItem = new OrderItem(item, Amount);
            Basket.Add(SelectedItem);
            CalcPrice();
            Points = CalcPoints(TotalPrice);
        }
        public void SetQuantity(int Amount)
        {
            SelectedItem.Count = Amount;
        }
        private void CalcPrice() { foreach(var Item in Basket) TotalPrice += Item.Price; }
        private int CalcPoints(double price) { return (int)(TotalPrice / 50.0); }
    }
    public void Checkout()
    {

    }
}
