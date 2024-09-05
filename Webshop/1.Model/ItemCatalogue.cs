using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Webshop._1.Model;

namespace Webshop
{
    public class ItemCatalogue
    {

        public List<Item> ItemList { get; set; }
        public Item SelectedItem { get; set; }

        public ItemCatalogue()
        {
            ItemList = new List<Item>();
            SelectedItem = new Item();
        }

        public void AddItem()
        {
            Item item = new Item();
            SelectedItem = item;
            ItemList.Add(SelectedItem);
        }

        public void DeleteItem()
        {
            ItemList.Remove(SelectedItem);
        }

        public Item GetItem(int ItemID)
        {
            Item item = ItemList.FirstOrDefault(i => i.ID == ItemID);
            return item;
        }

        public void UpdateItem(Item item)
        {
            // Code to update the item in the list
        }
    }
}
