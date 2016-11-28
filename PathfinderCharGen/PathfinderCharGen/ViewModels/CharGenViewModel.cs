using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.Commands.Specific;
using PathfinderCharGen.Commands.Generic;

namespace PathfinderCharGen.ViewModels
{
    class CharGenViewModel : ViewModelBase
    {

        public CharGenViewModel()
        {
            strModCmd = new StrengthModCommand(this);
            dexModCmd = new DexterityModCommand(this);
            calcCmd = new CalculateCommand(this);
        }


        #region PrivateFields
        private int str_score = 10;
        private int str_mod = 0;
        private int str_tempScore = 0;
        private int str_tempMod = 0;

        private int dex_score = 10;
        private int dex_mod = 0;
        private int dex_tempScore = 0;
        private int dex_tempMod = 0;

        private int con_score = 10;
        private int con_mod = 0;
        private int con_tempScore = 0;
        private int con_tempMod = 0;

        private int int_score = 10;
        private int int_mod = 0;
        private int int_tempScore = 0;
        private int int_tempMod = 0;

        private int wis_score = 10;
        private int wis_mod = 0;
        private int wis_tempScore = 0;
        private int wis_tempMod = 0;

        private int cha_score = 10;
        private int cha_mod = 0;
        private int cha_tempScore = 0;
        private int cha_tempMod = 0;

        private StrengthModCommand strModCmd;
        private DexterityModCommand dexModCmd;
        private CalculateCommand calcCmd;
        #endregion
      

        #region Public Properties

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

        public int STR_MOD
        {
            get { return str_mod; }
            set
            {
                str_mod = value;
                OnPropertyChanged("STR_MOD");

            }
        }

        public int DEX_MOD
        {
            get { return dex_mod; }

            set
            {
                dex_mod = value;
                OnPropertyChanged("DEX_MOD");
            }
        }
        #endregion


        #region Commands
        public ICommand StrengthModCommand
        {
            get
            {
                return strModCmd;
            }
        }

        public ICommand DexterityModCommand
        {
            get
            {
                return dexModCmd;
            }
        }

        public ICommand CalculateCommand
        {
            get
            {
                return calcCmd;
            }
        }
        #endregion


        #region Methods

        internal void CalculateStrengthMod()
        {
            STR_MOD = (int)Math.Floor((str_score - 10.0f) / 2.0f);
        }

        internal void CalculateDexterityMod()
        {
            DEX_MOD = (int)Math.Floor((dex_score - 10.0f) / 2.0f);
        }
        #endregion


    }
}
