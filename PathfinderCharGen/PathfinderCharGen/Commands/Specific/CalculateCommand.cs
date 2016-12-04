using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Commands.Specific
{
    class CalculateCommand : ICommand
    {

        private CharSheetViewModel charSheetViewModel;
        public CalculateCommand(CharSheetViewModel vm)
        {
            charSheetViewModel = vm;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            charSheetViewModel.CalculateStrengthMod();
            charSheetViewModel.CalculateDexterityMod();
            charSheetViewModel.CalculateConstitutionMod();
             
            charSheetViewModel.CalculateIntelligenceMod();
            charSheetViewModel.CalculateWisdomMod();
            charSheetViewModel.CalculateCharismaMod();
          
            charSheetViewModel.CalculateArmorBonus();

            charSheetViewModel.CalculateFortBonus();
            charSheetViewModel.CalculateReflexBonus();
            charSheetViewModel.CalculateWillBonus();
                
            charSheetViewModel.CalculateMAB();
            charSheetViewModel.CalculateCMB();
            charSheetViewModel.CalculateCMD();
            charSheetViewModel.CalculateRAB();
                
            charSheetViewModel.CalculateINIT();
        
        }
    }
}