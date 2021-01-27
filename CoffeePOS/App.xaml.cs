using CoffeePOS.Models;
using CoffeePOS.Services;
using CoffeePOS.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CoffeePOS
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            /*new CrudApiService<User>("users/").Store(new User { Name = "", Email = "admin@admin.com", Password = "" }).ContinueWith((task) =>
            {
                var index = task.Result;
            });



            new CrudApiService<User>("users/").GetAll().ContinueWith((task) =>
            {
                var index = task.Result;
            });*/

            Window window = new MainWindow();
            window.DataContext = new MainVM();  
            window.Show();
            base.OnStartup(e);
        }
    }
}
