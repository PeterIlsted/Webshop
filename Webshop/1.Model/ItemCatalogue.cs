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
    public class ItemCatalogue : IRepository<Item>
    {
        public List<Item> ItemList { get; set; }
        public Item SelectedItem { get; set; }

        public IEnumerable<Item> GetAllTypes()
        {
            return ItemList;
        }

        public Item GetByID(int ID)
        {
            return ItemList.FirstOrDefault(i => i.ItemID == ID);
        }

        public void AddType(Item type)
        {
            ItemList.Add ((Item)type);
        }

        public void DeleteType(int ID)
        {
            Item item = ItemList.FirstOrDefault(i => i.ItemID == ID);
            ItemList.Remove(item);
        }

        public void UpdateType(Item type)
        {
            Item ExistingItem = GetByID(type.ItemID);
            if (ExistingItem != null)
            {
                ItemList.Add(ExistingItem);
            }
            else
                ExistingItem = type;
        }
    }
}
