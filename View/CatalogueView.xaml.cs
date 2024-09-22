using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Webshop.Model;
using Webshop.Repository;

namespace Webshop.View
{
    /// <summary>
    /// Interaction logic for CatalogueView.xaml
    /// </summary>
    public partial class CatalogueView : Window
    {
        public CatalogueView()
        {
            var ItemCatalogue = new Repository.ItemCatalogue();
            CatalogueViewModel vm = new CatalogueViewModel(ItemCatalogue);
            InitializeComponent();
            DataContext = vm;
        }
    }
}
