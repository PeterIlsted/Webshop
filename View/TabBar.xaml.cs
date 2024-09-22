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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Webshop.Repository;

namespace Webshop.View
{
    /// <summary>
    /// Interaction logic for TabBar.xaml
    /// </summary>
    public partial class TabBar : UserControl
    {
        CatalogueView catalogueView;
        //public TabBar(IRepository<Model.Product> repository)
        //{
        //    //catalogueView = new CatalogueView(repository);
        //    InitializeComponent();
        //}
        public TabBar()
        {
            InitializeComponent();
        }
        private void NavigateCatalogue(object sender, RoutedEventArgs e)
        {
            catalogueView.Show();
            Window.GetWindow(this)?.Close();
        }
    }
}
