using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Commands.Specific
{
    class DexterityModCommand : ICommand
    {

        private CharGenViewModel charGenViewModel;
        public DexterityModCommand(CharGenViewModel vm)
        {
            charGenViewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            charGenViewModel.CalculateDexterityMod();
        }
    }
}