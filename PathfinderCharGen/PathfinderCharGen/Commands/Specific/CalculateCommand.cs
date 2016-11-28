using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Commands.Generic
{
    class CalculateCommand : ICommand
    {

        private CharGenViewModel charGenViewModel;
        public CalculateCommand(CharGenViewModel vm)
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
            charGenViewModel.CalculateStrengthMod();
            charGenViewModel.CalculateDexterityMod();
            charGenViewModel.CalculateConstitutionMod();

            charGenViewModel.CalculateIntelligenceMod();
            charGenViewModel.CalculateWisdomMod();
            charGenViewModel.CalculateCharismaMod();

            charGenViewModel.CalculateArmorBonus();

            charGenViewModel.CalculateFortBonus();
            charGenViewModel.CalculateReflexBonus();
            charGenViewModel.CalculateWillBonus();

           
        }
    }
}