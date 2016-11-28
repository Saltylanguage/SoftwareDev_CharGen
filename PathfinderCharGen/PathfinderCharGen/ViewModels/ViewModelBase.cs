using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PathfinderCharGen.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            if(PropertyName != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

    }
}
