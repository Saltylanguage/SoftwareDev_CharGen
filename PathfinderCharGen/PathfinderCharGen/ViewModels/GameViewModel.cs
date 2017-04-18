using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.ViewModels
{
    class GameViewModel :ViewModelBase
    {

        private string CommandText = "Awesome!";

        public string CMD_Text
        {
            get { return CommandText; }
            set
            {
                CommandText = value;
                OnPropertyChanged("CMD_Text");
            }
        }

    }
}
