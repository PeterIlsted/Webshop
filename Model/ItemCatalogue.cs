using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Webshop.Model;

namespace Webshop.Model
{
    public class ItemCatalogue : IRepository<Item>
    {
        public List<Item> ItemList { get; set; }

        public IEnumerable<Item> GetAllTypes()
        {
            return ItemList;
        }

        public Item GetByID(int ID) { return ItemList.FirstOrDefault(i => i.ItemID == ID); }

        public int AddType(Item type)
        {
            ItemList.Add ((Item)type);
            return type.ItemID;
        }

        public void DeleteType(int ID)
        {
            ItemList.Remove(GetByID(ID));
        }

        public void UpdateType(Item type)
        {
            Item item = GetByID(type.ItemID);
            int index = ItemList.IndexOf(item);
            if (index != -1) { ItemList[index] = type; }
            else { ItemList.Add(type); }
        }
    }
}
