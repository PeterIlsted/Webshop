using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop.Model;
using Webshop.MVVM;
using Webshop.Repository;

using Microsoft.Extensions.Configuration;
using System.IO;

namespace Webshop.Model
{
    class CatalogueViewModel : ViewModelBase
    {
        private readonly IRepository<Product> repository;
        public CatalogueViewModel(IRepository<Product> repository)
        {

            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
            Products = new ObservableCollection<Product>(repository.GetAll());
        }
        public ObservableCollection<Product> Products { get; private set; }
        
    }
}
