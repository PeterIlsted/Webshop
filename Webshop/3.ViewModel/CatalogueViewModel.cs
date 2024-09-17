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
    class CatalogueViewModel : ViewModelBase
    {
        private readonly IRepository<Item> repository;
        public ObservableCollection<Item> ItemList { get; set; }
        private Item _selectedItem;
        public Item SelectedItem 
        {
            get { return _selectedItem; }
            set 
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }
        public CatalogueViewModel(IRepository<Item> repository)
        {
            this.repository = repository;
            ItemList = new ObservableCollection<Item>(repository.GetAllTypes());
        }
        public void AddItem()
        {
            _selectedItem = new Item();
            ItemList.Add(SelectedItem);
            repository.AddType(SelectedItem);
        }
        public void RemoveItem()
        {
            repository.DeleteType(SelectedItem.ItemID);
            ItemList.Remove(SelectedItem);
        }
        public void EditItem()
        {
            // skal lige have færdiggjort denne her
        }
    }
}
