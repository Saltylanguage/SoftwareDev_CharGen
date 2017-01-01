using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.ViewModels
{
    class WizardStep5ViewModel : ViewModelBase
    {
        #region private fields

        private int points = 0;

        #endregion

        #region public Properties

        public int POINTS
        {
            get { return points; }
            set
            {
                points = value;
                OnPropertyChanged("POINTS");
            }
        }

        #endregion

    }
}
