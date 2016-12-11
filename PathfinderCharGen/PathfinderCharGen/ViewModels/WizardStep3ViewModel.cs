using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PathfinderCharGen.ViewModels
{
    class WizardStep3ViewModel : ViewModelBase
    {
        private ReactiveLeveling.Pathfinder.Character character = new ReactiveLeveling.Pathfinder.Character();

        public ReactiveLeveling.Pathfinder.Character CHAR
        {
            get { return character; }
            set
            {
                character = value;
                OnPropertyChanged("CHAR");
            }
        }
        
    }
}
