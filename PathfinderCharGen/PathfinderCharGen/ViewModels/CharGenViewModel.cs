using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.Commands.Specific;
using PathfinderCharGen.Commands.Generic;
using ReactiveLeveling;


namespace PathfinderCharGen.ViewModels
{



    class CharGenViewModel : ViewModelBase
    {
        public Character character = new Character();
        public CharGenViewModel()
        {
            calcCmd = new CalculateCommand(this);
        }

        #region PrivateFields

        //private int str_score = 10;
        //private int str_mod = 0;

        //private int dex_score = 10;
        private int dex_mod = 0;    

        //private int con_score = 10;
        private int con_mod = 0;

        //private int int_score = 10;
        private int int_mod = 0;

        //private int wis_score = 10;
        private int wis_mod = 0;

        //private int cha_score = 10;
        private int cha_mod = 0;

        private int ac_total = 10;
        private int ac_armorBonus = 0;
        private int ac_dexBonus = 0;
        private int ac_dodgeBonus = 0;
        private int ac_sizeBonus = 0;
        private int ac_naturalBonus = 0;
        private int ac_deflectBonus = 0;
        private int ac_miscBonus = 0;

        private int fort_Total = 0;
        private int fort_Base = 0;
        private int fort_Magic = 0;
        private int fort_Misc = 0;
        private int fort_Temp = 0;

        private int ref_Total = 0;
        private int ref_Base = 0;
        private int ref_Magic = 0;
        private int ref_Misc = 0;
        private int ref_Temp = 0;

        private int will_Total = 0;
        private int will_Base = 0;
        private int will_Magic = 0;
        private int will_Misc = 0;
        private int will_Temp = 0;

        private int baseAttackBonus = 0;

        private int meleeTotalBonus = 0;
        private int meleeSizeBonus = 0;
        private int meleeMiscBonus = 0;
        private int meleeTempBonus = 0;

        private int combateManeuverTotalBonus = 0;
        private int combatManeuverSizeBonus = 0;
        private int combatManeuverMiscBonus = 0;
        private int combatManeuverTempBonus = 0;

        private int combatManeuverDefense = 10;
        private int combatManeuverDefenseMisc = 0;

        private int rangeTotalBonus = 0;
        private int rangeSizeBonus = 0;
        private int rangeMiscBonus = 0;
        private int rangeTempBonus = 0;

        private string className = "Ranger";
   
        private CalculateCommand calcCmd;
        #endregion

        #region Public Properties


        public uint STR_Score
        {
            get { return character.statMgr.Strength.Value; }
            set
            {
                character.statMgr.Strength.Value = value;
                OnPropertyChanged("STR_Score");
            }
        }

        public int STR_MOD
        {
            get { return character.statMgr.StrMod; }
            set
            {
                character.statMgr.StrMod = value;
                OnPropertyChanged("STR_MOD");
            }
        }

        public uint DEX_Score
        {
            get { return character.statMgr.Dexerity.Value; }
            set
            {
                character.statMgr.Dexerity.Value = value;
                OnPropertyChanged("DEX_Score");
            }
        }

        public uint CON_Score
        {
            get { return character.statMgr.Constitution.Value; }

            set
            {
                character.statMgr.Constitution.Value = value;
                OnPropertyChanged("CON_Score");
            }
        }

        public uint INT_Score
        {
            get { return character.statMgr.Intellect.Value; }

            set
            {
                character.statMgr.Intellect.Value = value;
                OnPropertyChanged("INT_Score");
            }
        }

        public uint WIS_Score
        {
            get { return character.statMgr.Wisdom.Value; }

            set
            {
                character.statMgr.Wisdom.Value = value;
                OnPropertyChanged("WIS_Score");
            }
        }

        public uint CHA_Score
        {
            get { return character.statMgr.Charisma.Value; }

            set
            {
                character.statMgr.Charisma.Value = value;
                OnPropertyChanged("CHA_Score");
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

        public int CON_MOD
        {
            get { return con_mod; }

            set
            {
                con_mod = value;
                OnPropertyChanged("CON_MOD");
            }
        }

        public int INT_MOD
        {
            get { return int_mod; }

            set
            {
                int_mod = value;
                OnPropertyChanged("INT_MOD");
            }
        }

        public int WIS_MOD
        {
            get { return wis_mod; }

            set
            {
                wis_mod = value;
                OnPropertyChanged("WIS_MOD");
            }
        }

        public int CHA_MOD
        {
            get { return cha_mod; }

            set
            {
                cha_mod = value;
                OnPropertyChanged("CHA_MOD");
            }


        }

        //ARMOR PROPERTIES
        public int AC_Total
        {
            get { return ac_total; }

            set
            {
                ac_total = value;
                OnPropertyChanged("AC_Total");
            }
        }

        public int AC_ArmorBonus
        {
            get { return ac_armorBonus; }

            set
            {
                ac_armorBonus = value;
                OnPropertyChanged("AC_ArmorBonus");
            }
        }

        public int AC_DexBonus
        {
            get { return ac_dexBonus; }

            set
            {
                ac_dexBonus = value;
                OnPropertyChanged("AC_DexBonus");
            }
        }

        public int AC_DodgeBonus
        {
            get { return ac_dodgeBonus; }

            set
            {
                ac_dodgeBonus = value;
                OnPropertyChanged("AC_DodgeBonus");
            }
        }

        public int AC_SizeBonus
        {
            get { return ac_sizeBonus; }

            set
            {
                ac_sizeBonus = value;
                OnPropertyChanged("AC_SizeBonus");
            }
        }

        public int AC_NaturalBonus
        {
            get { return ac_naturalBonus; }

            set
            {
                ac_naturalBonus = value;
                OnPropertyChanged("AC_NaturalBonus");
            }
        }

        public int AC_DeflectBonus
        {
            get { return ac_deflectBonus; }

            set
            {
                ac_deflectBonus = value;
                OnPropertyChanged("AC_DeflectBonus");
            }
        }

        public int AC_MiscBonus
        {
            get { return ac_miscBonus; }

            set
            {
                ac_miscBonus = value;
                OnPropertyChanged("AC_MiscBonus");
            }
        }

        //SAVE VALUES
        public int FORT_Total
        {
            get { return fort_Total; }

            set
            {
                fort_Total = value;
                OnPropertyChanged("FORT_Total");
            }
        }

        public int FORT_Base
        {
            get { return fort_Base; }

            set
            {
                fort_Base = value;
                OnPropertyChanged("FORT_Base");
            }
        }

        public int FORT_Magic_Bonus
        {
            get { return fort_Magic; }

            set
            {
                fort_Magic = value;
                OnPropertyChanged("FORT_Magic_Bonus");
            }
        }

        public int FORT_Temp_Bonus
        {
            get { return fort_Temp; }

            set
            {
                fort_Temp = value;
                OnPropertyChanged("FORT_Temp_Bonus");
            }
        }

        public int FORT_Misc_Bonus
        {
            get { return fort_Misc; }

            set
            {
                fort_Misc = value;
                OnPropertyChanged("FORT_Misc_Bonus");
            }
        }

        public int REF_Total
        {
            get { return ref_Total; }

            set
            {
                ref_Total = value;
                OnPropertyChanged("REF_Total");
            }
        }

        public int REF_Base
        {
            get { return ref_Base; }
            set
            {
                ref_Base = value;
                OnPropertyChanged("REF_Base");
            }
        }

        public int REF_Magic_Bonus
        {
            get { return ref_Magic; }

            set
            {
                ref_Magic = value;
                OnPropertyChanged("REF_Magic_Bonus");
            }
        }

        public int REF_Temp_Bonus
        {
            get { return ref_Temp; }

            set
            {
                ref_Temp = value;
                OnPropertyChanged("REF_Temp_Bonus");
            }
        }

        public int REF_Misc_Bonus
        {
            get { return ref_Misc; }

            set
            {
                ref_Misc = value;
                OnPropertyChanged("REF_Misc_Bonus");
            }
        }


        public int WILL_Total
        {
            get { return will_Total; }

            set
            {
                will_Total = value;
                OnPropertyChanged("WILL_Total");
            }
        }

        public int WILL_Base
        {
            get { return will_Base; }

            set
            {
                will_Base = value;
                OnPropertyChanged("WILL_Base");
            }
        }

        public int WILL_Magic_Bonus
        {
            get { return will_Magic; }

            set
            {
                will_Magic = value;
                OnPropertyChanged("WILL_Magic_Bonus");
            }
        }

        public int WILL_Temp_Bonus
        {
            get { return will_Temp; }

            set
            {
                will_Temp = value;
                OnPropertyChanged("WILL_Temp_Bonus");
            }
        }

        public int WILL_Misc_Bonus
        {
            get { return will_Misc; }

            set
            {
                will_Misc = value;
                OnPropertyChanged("WILL_Misc_Bonus");
            }
        }

        public int BAB
        {
            get { return baseAttackBonus; }

            set
            {
                baseAttackBonus = value;
                OnPropertyChanged("BAB_Total");
            }
        }

        public int CMD
        {
            get { return combatManeuverDefense; }

            set
            {
                combatManeuverDefense = value;
                OnPropertyChanged("CMD");
            }
        }
        public int CMD_Misc
        {
            get { return combatManeuverDefenseMisc; }
            set
            {
                combatManeuverDefenseMisc = value;
                OnPropertyChanged("CMD_Misc");
            }
        }

        public int MAB_Total
        {
            get { return meleeTotalBonus; }

            set
            {
                meleeTotalBonus = value;
                OnPropertyChanged("MAB_Total");
            }
            
        }

        public int MAB_Size
        {
            get { return meleeSizeBonus; }

            set
            {
                meleeSizeBonus = value;
                OnPropertyChanged("MAB_Size");
            }
        }

        public int MAB_Misc
        {
            get { return meleeMiscBonus; }

            set
            {
                meleeMiscBonus = value;
                OnPropertyChanged("MAB_Misc");
            }
        }

        public int MAB_Temp
        {
            get { return meleeTempBonus; }

            set
            {
                meleeTempBonus = value;
                OnPropertyChanged("MAB_Temp");
            }
        }
        
        public int CMB_Total
        {
            get { return combateManeuverTotalBonus; }
            set
            {
                combateManeuverTotalBonus = value;
                OnPropertyChanged("CMB_Total");
            }
        }

        public int CMB_Size
        {
            get { return combatManeuverSizeBonus; }

            set
            {
                combatManeuverSizeBonus = value;
                OnPropertyChanged("CMB_Size");
            }
        }

        public int CMB_Misc
        {
            get { return combatManeuverMiscBonus; }

            set
            {
                combatManeuverMiscBonus = value;
                OnPropertyChanged("CMB_Misc");
            }
        }

        public int CMB_Temp
        {
            get { return combatManeuverTempBonus; }

            set
            {
                combatManeuverTempBonus = value;
                OnPropertyChanged("CMB_Temp");
            }
        }

        public int RAB_Total
        {
            get { return rangeTotalBonus; }
            set
            {
                rangeTotalBonus = value;
                OnPropertyChanged("RAB_Total");
            }
        }

        public int RAB_Size
        {
            get { return rangeSizeBonus; }

            set
            {
                rangeSizeBonus = value;
                OnPropertyChanged("RAB_Size");
            }
        }

        public int RAB_Misc
        {
            get { return rangeMiscBonus; }
            set
            {
                rangeMiscBonus = value;
                OnPropertyChanged("RAB_Misc");
            }
        }

        public int RAB_Temp
        {
            get { return rangeTempBonus; }
            set
            {
                rangeTempBonus = value;
                OnPropertyChanged("RAB_Temp");
            }
        }

        //SKILL PROPERTIES

        public string CLASS_Name
        {
            get { return className; }

            set
            {
                className = value;
                OnPropertyChanged("CLASS_Name");
            }

        }



        #endregion


        #region Commands

        public ICommand CalculateCommand
        {
            get
            {
                return calcCmd;
            }
        }
        #endregion

        #region Methods
        void CalculateStatMod(int Score, int Mod)
        {
            Mod = (int)Math.Floor((Score - 10.0f) / 2.0f);
        }

        //internal void CalculateStrengthMod()
        //{
        //    STR_MOD = (int)Math.Floor((str_score - 10.0f) / 2.0f);
        //}

        //internal void CalculateDexterityMod()
        //{
        //    DEX_MOD = (int)Math.Floor((dex_score - 10.0f) / 2.0f);
        //}

        //internal void CalculateConstitutionMod()
        //{
        //    CON_MOD = (int)Math.Floor((con_score - 10.0f) / 2.0f);
        //}

        //internal void CalculateIntelligenceMod()
        //{
        //    INT_MOD = (int)Math.Floor((int_score - 10.0f) / 2.0f);
        //}

        //internal void CalculateWisdomMod()
        //{
        //    WIS_MOD = (int)Math.Floor((wis_score - 10.0f) / 2.0f);
        //}

        //internal void CalculateCharismaMod()
        //{
        //    CHA_MOD = (int)Math.Floor((cha_score - 10.0f) / 2.0f);
        //}

        internal void CalculateArmorBonus()
        {
            AC_Total = ac_armorBonus + dex_mod + ac_dodgeBonus + ac_sizeBonus + ac_naturalBonus + ac_deflectBonus + ac_miscBonus + 10;
        }

        internal void CalculateFortBonus()
        {
            FORT_Total = fort_Base + con_mod + fort_Magic + fort_Misc + fort_Temp;
        }

        internal void CalculateReflexBonus()
        {
            REF_Total = ref_Base + DEX_MOD + ref_Magic + ref_Misc + ref_Temp;
        }

        internal void CalculateWillBonus()
        {
            WILL_Total = will_Base + wis_mod + will_Magic + will_Misc + will_Temp;
        }

        internal void CalculateBAB()
        {
            BAB = baseAttackBonus;
        }

        internal void CalculateMAB()
        {
            MAB_Total = baseAttackBonus + /*str_mod*/character.statMgr.StrMod + meleeSizeBonus + meleeMiscBonus + meleeTempBonus;
        }

        internal void CalculateCMD()
        {
            CMD = 10 + baseAttackBonus +/*str_mod*/character.statMgr.StrMod + dex_mod + combatManeuverSizeBonus + combatManeuverDefenseMisc;
        }

        internal void CalculateCMB()
        {
            CMB_Total = baseAttackBonus +/*str_mod*/character.statMgr.StrMod + combatManeuverSizeBonus + combatManeuverMiscBonus + combatManeuverTempBonus;
        }

        internal void CalculateRAB()
        {
            RAB_Total = baseAttackBonus + dex_mod + rangeSizeBonus + rangeMiscBonus + rangeTempBonus;
        }            
        #endregion
    }
}
