using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands;

namespace PathfinderCharGen.ViewModels
{
    class GameViewModel : ViewModelBase
    {
       public ScriptParser scriptParser;

        public GameViewModel()
        {
            scriptParser = new ScriptParser();
        }

        private string CommandText = "";

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
