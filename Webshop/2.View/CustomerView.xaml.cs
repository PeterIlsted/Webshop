﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : Window
    {
        CustomerViewModel vm;
        public CustomerView()
        {
            vm = new CustomerViewModel();
            InitializeComponent();
            DataContext = vm;
        }
        public CustomerView(CustomerViewModel viewModel)
        {
            this.vm = viewModel;
            InitializeComponent();
            DataContext = vm;
        }
    }
}
