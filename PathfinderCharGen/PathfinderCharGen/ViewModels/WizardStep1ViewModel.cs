using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PathfinderCharGen.ViewModels
{
    class WizardStep1ViewModel : ViewModelBase
    {
        private string playerName;
        private string charName;

        public string PLAYER_Name
        {
            get { return playerName; }
            set
            {
                playerName = value;
                OnPropertyChanged("PLAYER_Name");
                
            }
        }

        public string CHAR_Name
        {
            get { return charName; }
            set
            {
                charName = value;
                OnPropertyChanged("CHAR_Name");
            }
        }

    }
}
