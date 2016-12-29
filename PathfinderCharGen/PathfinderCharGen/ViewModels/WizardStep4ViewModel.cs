using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PathfinderCharGen.Commands.Specific;

namespace PathfinderCharGen.ViewModels
{
    class WizardStep4ViewModel : ViewModelBase
    {

        public WizardStep4ViewModel()
        {
            calcStats = new CalculateStatModsCommand(this);
        }

        #region Private Fields

        private int remainingPoints;
        private int maxPoints;

        private int str_score = 10;
        private int dex_score = 10;
        private int con_score = 10;
        private int int_score = 10;
        private int wis_score = 10;
        private int cha_score = 10;

        private int str_mod = 0;
        private int dex_mod = 0;
        private int con_mod = 0;
        private int int_mod = 0;
        private int wis_mod = 0;
        private int cha_mod = 0;

        private CalculateStatModsCommand calcStats;

        #endregion

        #region Public Properties
        public int NumPointsRemaining
        {
            get { return remainingPoints; }
            set
            {
                remainingPoints = value;

                OnPropertyChanged("NumPoints");
            }
        }

        public int NumMaxPoints
        {
            get { return maxPoints; }
            set
            {
                maxPoints = value;
                OnPropertyChanged("NumMaxPoints");
            }
        }

        public int STR_Score
        {
            get { return str_score; }
            set
            {
                str_score = value;
                OnPropertyChanged("STR_Score");
            }
        }
        public int DEX_Score
        {
            get { return dex_score; }
            set
            {
                dex_score = value;
                OnPropertyChanged("DEX_Score");
            }
        }
        public int CON_Score
        {
            get { return con_score; }
            set
            {
                con_score = value;
                OnPropertyChanged("CON_Score");
            }
        }
        public int INT_Score
        {
            get { return int_score; }
            set
            {
                int_score = value;
                OnPropertyChanged("INT_Score");
            }
        }
        public int WIS_Score
        {
            get { return wis_score; }
            set
            {
                wis_score = value;
                OnPropertyChanged("WIS_Score");
            }
        }
        public int CHA_Score
        {
            get { return cha_score; }
            set
            {
                cha_score = value;
                OnPropertyChanged("CHA_Score");
            }
        }


        public int STR_Mod
        {
            get { return str_mod; }
            set
            {
                str_mod = value;
                OnPropertyChanged("STR_Mod");
            }
        }
        public int DEX_Mod
        {
            get { return dex_mod; }
            set
            {
                dex_mod = value;
                OnPropertyChanged("DEX_Mod");
            }
        }
        public int CON_Mod
        {
            get { return con_mod; }
            set
            {
                con_mod = value;
                OnPropertyChanged("CON_Mod");
            }
        }
        public int INT_Mod
        {
            get { return int_mod; }
            set
            {
                int_mod = value;
                OnPropertyChanged("INT_Mod");
            }
        }
        public int WIS_Mod
        {
            get { return wis_mod; }
            set
            {
                wis_mod = value;
                OnPropertyChanged("WIS_Mod");
            }
        }
        public int CHA_Mod
        {
            get { return cha_mod; }
            set
            {
                cha_mod = value;
                OnPropertyChanged("CHA_Mod");
            }
        }

        #endregion

        #region Commands

        public ICommand calcStatMods
        {
            get
            {
                return calcStats;
            }
        }

        #endregion

        #region Methods

        internal void CalculateSTR_Mod()
        {
            STR_Mod = (int)Math.Floor((str_score - 10.0f) / 2.0f);
        }

        internal void CalculateDEX_Mod()
        {
            DEX_Mod = (int)Math.Floor((dex_score - 10.0f) / 2.0f);
        }

        internal void CalculateCON_Mod()
        {
            CON_Mod = (int)Math.Floor((con_score - 10.0f) / 2.0f);
        }

        internal void CalculateINT_Mod()
        {
           INT_Mod = (int)Math.Floor((int_score - 10.0f) / 2.0f);
        }

        internal void CalculateWIS_Mod()
        {
            WIS_Mod = (int)Math.Floor((wis_score - 10.0f) / 2.0f);
        }

        internal void CalculateCHA_Mod()
        {
            CHA_Mod = (int)Math.Floor((cha_score - 10.0f) / 2.0f);
        }
        #endregion

    }





}

