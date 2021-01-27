using CoffeePOS.States.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeePOS.ViewModel
{
    /// <summary>
    /// - Controls Navigation
    /// </summary>
    public class MainVM : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
