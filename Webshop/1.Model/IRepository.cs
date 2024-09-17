using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop._1.Model
{
    interface IRepository<Type>
    {
        IEnumerable<Type> GetAllTypes();
        Type GetByID(int ID);
        int AddType(Type type);
        void DeleteType(int ID);
        void UpdateType(Type type);

    }
}
