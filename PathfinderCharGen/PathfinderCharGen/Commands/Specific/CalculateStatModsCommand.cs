using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Commands.Specific
{


    class CalculateStatModsCommand : ICommand
    {

        private WizardStep4ViewModel wizardViewModel;

        public CalculateStatModsCommand(WizardStep4ViewModel vm)
        {
            wizardViewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            wizardViewModel.CalculateSTR_Mod();
            wizardViewModel.CalculateDEX_Mod();
            wizardViewModel.CalculateCON_Mod();
            wizardViewModel.CalculateINT_Mod();
            wizardViewModel.CalculateWIS_Mod();
            wizardViewModel.CalculateCHA_Mod();
        }
    }
}
