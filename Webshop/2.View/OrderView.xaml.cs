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
using Webshop._3.ViewModel;

namespace Webshop._2.View
{
    /// <summary>
    /// Interaction logic for OrderView.xaml
    /// </summary>
    public partial class OrderView : Window
    {
        public OrderView()
        {
            OrderViewModel vm = new OrderViewModel();
            InitializeComponent();
            DataContext = vm;
        }
        public OrderView(OrderViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
