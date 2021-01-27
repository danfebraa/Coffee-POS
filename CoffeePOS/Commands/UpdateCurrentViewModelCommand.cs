using CoffeePOS.States.Navigators;
using CoffeePOS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoffeePOS.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private INavigator _navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType) 
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Food:
                        _navigator.CurrentViewModel = new FoodVM();
                        break;
                    case ViewType.Drinks:
                        _navigator.CurrentViewModel = new DrinksVM();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}