using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop.Model
{
    public class Category
    {
        public string Name { get; set; }
        private int _catID { get; }
        public Category(string name, int id)
        {
            _catID = id;
            Name = name;
        }
        public Category(string name) : this(name, 0) { }
        public Category() :this(null) { }
    }
}
