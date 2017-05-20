using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.ViewModels
{
    class ConnectionViewModel : ViewModelBase
    {


        private string ip;
       
        public string IP
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChanged("IP_TextBox");
            }
        }




    }
}
