using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System;
using Webshop.Repository;
using Webshop.MVVM;
using Webshop.View;

namespace Webshop
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var configuration = LoadConfiguration();


            string ConnectionString = configuration.GetConnectionString("DefaultConnection");
            ConfigurationSettings.Initialize(ConnectionString);

            var itemCatalogue = new ItemCatalogue();
           // var catalogueView = new CatalogueView(itemCatalogue);
        }
        private IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }

    }
}
