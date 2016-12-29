using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PathfinderCharGen.Commands.Specific;
using ReactiveLeveling.Pathfinder;


namespace PathfinderCharGen.ViewModels
{

    class CharSheetViewModel : ViewModelBase
    {

        public CharSheetViewModel()
        {
            calcCmd = new CalculateCommand(this);

        }

        #region PrivateFields

        private int str_score = 10;
        private int str_mod = 0;

        private int dex_score = 10;
        private int dex_mod = 0;

        private int con_score = 10;
        private int con_mod = 0;

        private int int_score = 10;
        private int int_mod = 0;

        private int wis_score = 10;
        private int wis_mod = 0;

        private int cha_score = 10;
        private int cha_mod = 0;

        private int ac_total = 10;
        private int ac_armorBonus;
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

        private int initTotal = 0;
        private int initMisc = 0;

        private string playerName = "";
        public string characterName = "";
        private string className = "";

        private int acrobaticsTotal = 0;
        private int acrobaticsRank = 0;
        private int acrobaticsMisc = 0;

        private int appraiseTotal = 0;
        private int appraiseRank = 0;
        private int appraiseMisc = 0;

        //private int ACP = 0;

        private int bluffTotal = 0;
        private int bluffRank = 0;
        private int bluffMisc = 0;

        private int climbTotal = 0;
        private int climbRank = 0;
        private int climbMisc = 0;

        private int craftTotal = 0;
        private int craftRank = 0;
        private int craftMisc = 0;

        private int diplomacyTotal = 0;
        private int diplomacyRank = 0;
        private int diplomacyMisc = 0;

        private int disableDeviceTotal = 0;
        private int disableDeviceRank = 0;
        private int disableDeviceMisc = 0;

        private int disguiseTotal = 0;
        private int disguiseRank = 0;
        private int disguiseMisc = 0;

        private int escapeArtistTotal = 0;
        private int escapeArtistRank = 0;
        private int escapeArtistMisc = 0;

        private int flyTotal = 0;
        private int flyRank = 0;
        private int flyMisc = 0;

        private int handleAnimalTotal = 0;
        private int handleAnimalRank = 0;
        private int handleAnimalMisc = 0;

        private int healTotal = 0;
        private int healRank = 0;
        private int healMisc = 0;

        private int intimidateTotal = 0;
        private int intimidateRank = 0;
        private int intimidateMisc = 0;

        private int linguisticsTotal = 0;
        private int linguisticsRank = 0;
        private int linguisticsMisc = 0;

        private int perceptionTotal = 0;
        private int perceptionRank = 0;
        private int perceptionMisc = 0;

        private int performTotal = 0;
        private int performRank = 0;
        private int performMisc = 0;

        private int professionTotal = 0;
        private int professionRank = 0;
        private int professionMisc = 0;

        private int rideTotal = 0;
        private int rideRank = 0;
        private int rideMisc = 0;

        private int senseMotiveTotal = 0;
        private int senseMotiveRank = 0;
        private int senseMotiveMisc = 0;

        private int sleightOfHandTotal = 0;
        private int sleightOfHandRank = 0;
        private int sleightOfHandMisc = 0;

        private int spellcraftTotal = 0;
        private int spellcraftRank = 0;
        private int spellcraftMisc = 0;

        private int stealthTotal = 0;
        private int stealthRank = 0;
        private int stealthMisc = 0;

        private int survivalTotal = 0;
        private int survivalRank = 0;
        private int survivalMisc = 0;

        private int swimTotal = 0;
        private int swimRank = 0;
        private int swimMisc = 0;

        private int useMagicDeviceTotal = 0;
        private int useMagicDeviceRank = 0;
        private int useMagicDeviceMisc = 0;

        private int arcanaTotal = 0;
        private int arcanaRank = 0;
        private int arcanaMisc = 0;

        private int dungeoneeringTotal = 0;
        private int dungeoneeringRank = 0;
        private int dungeoneeringMisc = 0;

        private int engineeringTotal = 0;
        private int engineeringRank = 0;
        private int engineeringMisc = 0;

        private int geographyTotal = 0;
        private int geographyRank = 0;
        private int geographyMisc = 0;

        private int historyTotal = 0;
        private int historyRank = 0;
        private int historyMisc = 0;

        private int localTotal = 0;
        private int localRank = 0;
        private int localMisc = 0;

        private int natureTotal = 0;
        private int natureRank = 0;
        private int natureMisc = 0;

        private int nobilityTotal = 0;
        private int nobilityRank = 0;
        private int nobilityMisc = 0;

        private int planesTotal = 0;
        private int planesRank = 0;
        private int planesMisc = 0;

        private int religionTotal = 0;
        private int religionRank = 0;
        private int religionMisc = 0;
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

        public int STR_MOD
        {
            get { return str_mod; }
            set
            {
                str_mod = value;
                OnPropertyChanged("STR_MOD");
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


        //COMBAT BONUSES
        public int BAB
        {
            get { return baseAttackBonus; }

            set
            {
                baseAttackBonus = value;
                OnPropertyChanged("BAB");
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

        public int INIT_Total
        {
            get { return initTotal; }
            set
            {
                initTotal = value;
                OnPropertyChanged("INIT_Total");
            }
        }

        public int INIT_Misc
        {
            get { return initMisc; }
            set
            {
                initMisc = value;
                OnPropertyChanged("INIT_Misc");
            }


        }

        //SKILL PROPERTIES

        public int Acrobatics_Rank
        {
            get { return acrobaticsRank; }
            set
            {
                acrobaticsRank = value;
                OnPropertyChanged("Acrobatics_Rank");
            }
        }

        public int Acrobatics_Misc
        {
            get { return acrobaticsMisc; }
            set
            {
                acrobaticsMisc = value;
                OnPropertyChanged("Acrobatics_Misc");
            }
        }

        public int Acrobatics_Total
        {
            get { return acrobaticsTotal; }
            set
            {
                acrobaticsTotal = value;
                OnPropertyChanged("Acrobatics_Total");
            }
        }

        public int Appraise_Rank
        {
            get { return appraiseRank; }
            set
            {
                appraiseRank = value;
                OnPropertyChanged("Appraise_Rank");
            }
        }

        public int Appraise_Misc
        {
            get { return appraiseMisc; }
            set
            {
                appraiseMisc = value;
                OnPropertyChanged("Appraise_Misc");
            }
        }

        public int Appraise_Total
        {
            get { return appraiseTotal; }
            set
            {
                appraiseTotal = value;
                OnPropertyChanged("Appraise_Total");
            }
        }

        public int Bluff_Rank
        {
            get { return bluffRank; }
            set
            {
                bluffRank = value;
                OnPropertyChanged("Bluff_Rank");
            }
        }

        public int Bluff_Misc
        {
            get { return bluffMisc; }
            set
            {
                bluffMisc = value;
                OnPropertyChanged("Bluff_Misc");
            }
        }

        public int Bluff_Total
        {
            get { return bluffTotal; }
            set
            {
                bluffTotal = value;
                OnPropertyChanged("Bluff_Total");
            }
        }

        public int Climb_Rank
        {
            get { return climbRank; }
            set
            {
                climbRank = value;
                OnPropertyChanged("Climb_Rank");
            }
        }

        public int Climb_Misc
        {
            get { return climbMisc; }
            set
            {
                climbMisc = value;
                OnPropertyChanged("Climb_Misc");
            }
        }

        public int Climb_Total
        {
            get { return climbTotal; }
            set
            {
                climbTotal = value;
                OnPropertyChanged("Climb_Total");
            }
        }

        public int Craft_Rank
        {
            get { return craftRank; }
            set
            {
                craftRank = value;
                OnPropertyChanged("Craft_Rank");
            }
        }

        public int Craft_Misc
        {
            get { return craftMisc; }
            set
            {
                craftMisc = value;
                OnPropertyChanged("Craft_Misc");
            }
        }

        public int Craft_Total
        {
            get { return craftTotal; }
            set
            {
                craftTotal = value;
                OnPropertyChanged("Craft_Total");
            }
        }

        public int Diplomacy_Rank
        {
            get { return diplomacyRank; }
            set
            {
                diplomacyRank = value;
                OnPropertyChanged("Diplomacy_Rank");
            }
        }

        public int Diplomacy_Misc
        {
            get { return diplomacyMisc; }
            set
            {
                diplomacyMisc = value;
                OnPropertyChanged("Diplomacy_Misc");
            }
        }

        public int Diplomacy_Total
        {
            get { return diplomacyTotal; }
            set
            {
                diplomacyTotal = value;
                OnPropertyChanged("Diplomacy_Total");
            }
        }

        public int Disable_Device_Rank
        {
            get { return disableDeviceRank; }
            set
            {
                disableDeviceRank = value;
                OnPropertyChanged("Disable_Device_Rank");
            }
        }

        public int Disable_Device_Misc
        {
            get { return disableDeviceMisc; }
            set
            {
                disableDeviceMisc = value;
                OnPropertyChanged("Disable_Device_Misc");
            }
        }

        public int Disable_Device_Total
        {
            get { return disableDeviceTotal; }
            set
            {
                disableDeviceTotal = value;
                OnPropertyChanged("Disable_Device_Total");
            }
        }

        public int Disguise_Rank
        {
            get { return disguiseRank; }
            set
            {
                disguiseRank = value;
                OnPropertyChanged("Disguise_Rank");
            }
        }

        public int Disguise_Misc
        {
            get { return disguiseMisc; }
            set
            {
                disguiseMisc = value;
                OnPropertyChanged("Disguise_Misc");
            }
        }

        public int Disguise_Total
        {
            get { return disguiseTotal; }
            set
            {
                disguiseTotal = value;
                OnPropertyChanged("Disguise_Total");
            }
        }

        public int Escape_Artist_Rank
        {
            get { return escapeArtistRank; }
            set
            {
                escapeArtistRank = value;
                OnPropertyChanged("Escape_Artist_Rank");
            }
        }

        public int Escape_Artist_Misc
        {
            get { return escapeArtistMisc; }
            set
            {
                escapeArtistMisc = value;
                OnPropertyChanged("Escape_Artist_Misc");
            }
        }

        public int Escape_Artist_Total
        {
            get { return escapeArtistTotal; }
            set
            {
                escapeArtistTotal = value;
                OnPropertyChanged("Escape_Artist_Total");
            }
        }

        public int Fly_Rank
        {
            get { return flyRank; }
            set
            {
                flyRank = value;
                OnPropertyChanged("Fly_Rank");
            }
        }

        public int Fly_Misc
        {
            get { return flyMisc; }
            set
            {
                flyMisc = value;
                OnPropertyChanged("Fly_Misc");
            }
        }

        public int Fly_Total
        {
            get { return flyTotal; }
            set
            {
                flyTotal = value;
                OnPropertyChanged("Fly_Total");
            }
        }

        public int Handle_Animal_Rank
        {
            get { return handleAnimalRank; }
            set
            {
                handleAnimalRank = value;
                OnPropertyChanged("Handle_Animal_Rank");
            }
        }

        public int Handle_Animal_Misc
        {
            get { return handleAnimalMisc; }
            set
            {
                handleAnimalMisc = value;
                OnPropertyChanged("Handle_Animal_Misc");
            }
        }

        public int Handle_Animal_Total
        {
            get { return handleAnimalTotal; }
            set
            {
                handleAnimalTotal = value;
                OnPropertyChanged("Handle_Animal_Total");
            }
        }

        public int Heal_Rank
        {
            get { return healRank; }
            set
            {
                healRank = value;
                OnPropertyChanged("Heal_Rank");
            }
        }

        public int Heal_Misc
        {
            get { return healMisc; }
            set
            {
                healMisc = value;
                OnPropertyChanged("Heal_Misc");
            }
        }

        public int Heal_Total
        {
            get { return healTotal; }
            set
            {
                healTotal = value;
                OnPropertyChanged("Heal_Total");
            }
        }

        public int Intimidate_Rank
        {
            get { return intimidateRank; }
            set
            {
                intimidateRank = value;
                OnPropertyChanged("Intimidate_Rank");
            }
        }

        public int Intimidate_Misc
        {
            get { return intimidateMisc; }
            set
            {
                intimidateMisc = value;
                OnPropertyChanged("Intimidate_Misc");
            }
        }

        public int Intimidate_Total
        {
            get { return intimidateTotal; }
            set
            {
                intimidateTotal = value;
                OnPropertyChanged("Intimidate_Total");
            }
        }

        public int Linguistics_Rank
        {
            get { return linguisticsRank; }
            set
            {
                linguisticsRank = value;
                OnPropertyChanged("Linguistics_Rank");
            }
        }

        public int Linguistics_Misc
        {
            get { return linguisticsMisc; }
            set
            {
                linguisticsMisc = value;
                OnPropertyChanged("Linguistics_Misc");
            }
        }

        public int Linguistics_Total
        {
            get { return linguisticsTotal; }
            set
            {
                linguisticsTotal = value;
                OnPropertyChanged("Linguistics_Total");
            }
        }

        public int Perception_Rank
        {
            get { return perceptionRank; }
            set
            {
                perceptionRank = value;
                OnPropertyChanged("Perception_Rank");
            }
        }

        public int Perception_Misc
        {
            get { return perceptionMisc; }
            set
            {
                perceptionMisc = value;
                OnPropertyChanged("Perception_Misc");
            }
        }

        public int Perception_Total
        {
            get { return perceptionTotal; }
            set
            {
                perceptionTotal = value;
                OnPropertyChanged("Perception_Total");
            }
        }

        public int Perform_Rank
        {
            get { return performRank; }
            set
            {
                performRank = value;
                OnPropertyChanged("Perform_Rank");
            }
        }

        public int Perform_Misc
        {
            get { return performMisc; }
            set
            {
                performMisc = value;
                OnPropertyChanged("Perform_Misc");
            }
        }

        public int Perform_Total
        {
            get { return performTotal; }
            set
            {
                performTotal = value;
                OnPropertyChanged("Perform_Total");
            }
        }

        public int Profession_Rank
        {
            get { return professionRank; }
            set
            {
                professionRank = value;
                OnPropertyChanged("Profession_Rank");
            }
        }

        public int Profession_Misc
        {
            get { return professionMisc; }
            set
            {
                professionMisc = value;
                OnPropertyChanged("Profession_Misc");
            }
        }

        public int Profession_Total
        {
            get { return professionTotal; }
            set
            {
                professionTotal = value;
                OnPropertyChanged("Profession_Total");
            }
        }

        public int Ride_Rank
        {
            get { return rideRank; }
            set
            {
                rideRank = value;
                OnPropertyChanged("Ride_Rank");
            }
        }

        public int Ride_Misc
        {
            get { return rideMisc; }
            set
            {
                rideMisc = value;
                OnPropertyChanged("Ride_Misc");
            }
        }

        public int Ride_Total
        {
            get { return rideTotal; }
            set
            {
                rideTotal = value;
                OnPropertyChanged("Ride_Total");
            }
        }

        public int Sense_Motive_Rank
        {
            get { return senseMotiveRank; }
            set
            {
                senseMotiveRank = value;
                OnPropertyChanged("Sense_Motive_Rank");
            }
        }

        public int Sense_Motive_Misc
        {
            get { return senseMotiveMisc; }
            set
            {
                senseMotiveMisc = value;
                OnPropertyChanged("Sense_Motive_Misc");
            }
        }

        public int Sense_Motive_Total
        {
            get { return senseMotiveTotal; }
            set
            {
                senseMotiveTotal = value;
                OnPropertyChanged("Sense_Motive_Total");
            }
        }

        public int Sleight_Of_Hand_Rank
        {
            get { return sleightOfHandRank; }
            set
            {
                sleightOfHandRank = value;
                OnPropertyChanged("Sleight_Of_Hand_Rank");
            }
        }

        public int Sleight_Of_Hand_Misc
        {
            get { return sleightOfHandMisc; }
            set
            {
                sleightOfHandMisc = value;
                OnPropertyChanged("Sleight_Of_Hand_Misc");
            }
        }

        public int Sleight_Of_Hand_Total
        {
            get { return sleightOfHandTotal; }
            set
            {
                sleightOfHandTotal = value;
                OnPropertyChanged("Sleight_Of_Hand_Total");
            }
        }

        public int Spellcraft_Rank
        {
            get { return spellcraftRank; }
            set
            {
                spellcraftRank = value;
                OnPropertyChanged("Spellcraft_Rank");
            }
        }

        public int Spellcraft_Misc
        {
            get { return spellcraftMisc; }
            set
            {
                spellcraftMisc = value;
                OnPropertyChanged("Spellcraft_Misc");
            }
        }

        public int Spellcraft_Total
        {
            get { return spellcraftTotal; }
            set
            {
                spellcraftTotal = value;
                OnPropertyChanged("Spellcraft_Total");
            }
        }

        public int Stealth_Rank
        {
            get { return stealthRank; }
            set
            {
                stealthRank = value;
                OnPropertyChanged("Stealth_Rank");
            }
        }

        public int Stealth_Misc
        {
            get { return stealthMisc; }
            set
            {
                stealthMisc = value;
                OnPropertyChanged("Stealth_Misc");
            }
        }

        public int Stealth_Total
        {
            get { return stealthTotal; }
            set
            {
                stealthTotal = value;
                OnPropertyChanged("Stealth_Total");
            }
        }

        public int Survival_Rank
        {
            get { return survivalRank; }
            set
            {
                survivalRank = value;
                OnPropertyChanged("Survival_Rank");
            }
        }

        public int Survival_Misc
        {
            get { return survivalMisc; }
            set
            {
                survivalMisc = value;
                OnPropertyChanged("Survival_Misc");
            }
        }

        public int Survival_Total
        {
            get { return survivalTotal; }
            set
            {
                survivalTotal = value;
                OnPropertyChanged("Survival_Total");
            }
        }

        public int Swim_Rank
        {
            get { return swimRank; }
            set
            {
                swimRank = value;
                OnPropertyChanged("Swim_Rank");
            }
        }

        public int Swim_Misc
        {
            get { return swimMisc; }
            set
            {
                swimMisc = value;
                OnPropertyChanged("Swim_Misc");
            }
        }

        public int Swim_Total
        {
            get { return swimTotal; }
            set
            {
                swimTotal = value;
                OnPropertyChanged("Swim_Total");
            }
        }

        public int Use_Magic_Device_Rank
        {
            get { return useMagicDeviceRank; }
            set
            {
                useMagicDeviceRank = value;
                OnPropertyChanged("Use_Magic_Device_Rank");
            }
        }

        public int Use_Magic_Device_Misc
        {
            get { return useMagicDeviceMisc; }
            set
            {
                useMagicDeviceMisc = value;
                OnPropertyChanged("Use_Magic_Device_Misc");
            }
        }

        public int Use_Magic_Device_Total
        {
            get { return useMagicDeviceTotal; }
            set
            {
                useMagicDeviceTotal = value;
                OnPropertyChanged("Use_Magic_Device_Total");
            }
        }

        public int Arcana_Rank
        {
            get { return arcanaRank; }
            set
            {
                arcanaRank = value;
                OnPropertyChanged("Arcana_Rank");
            }
        }

        public int Arcana_Misc
        {
            get { return arcanaMisc; }
            set
            {
                arcanaMisc = value;
                OnPropertyChanged("Arcana_Misc");
            }
        }

        public int Arcana_Total
        {
            get { return arcanaTotal; }
            set
            {
                arcanaTotal = value;
                OnPropertyChanged("Arcana_Total");
            }
        }

        public int Dungeoneering_Rank
        {
            get { return dungeoneeringRank; }
            set
            {
                dungeoneeringRank = value;
                OnPropertyChanged("Dungeoneering_Rank");
            }
        }

        public int Dungeoneering_Misc
        {
            get { return dungeoneeringMisc; }
            set
            {
                dungeoneeringMisc = value;
                OnPropertyChanged("Dungeoneering_Misc");
            }
        }

        public int Dungeoneering_Total
        {
            get { return dungeoneeringTotal; }
            set
            {
                dungeoneeringTotal = value;
                OnPropertyChanged("Dungeoneering_Total");
            }
        }

        public int Engineering_Rank
        {
            get { return engineeringRank; }
            set
            {
                engineeringRank = value;
                OnPropertyChanged("Engineering_Rank");
            }
        }

        public int Engineering_Misc
        {
            get { return engineeringMisc; }
            set
            {
                engineeringMisc = value;
                OnPropertyChanged("Engineering_Misc");
            }
        }

        public int Engineering_Total
        {
            get { return engineeringTotal; }
            set
            {
                engineeringTotal = value;
                OnPropertyChanged("Engineering_Total");
            }
        }

        public int Geography_Rank
        {
            get { return geographyRank; }
            set
            {
                geographyRank = value;
                OnPropertyChanged("Geography_Rank");
            }
        }

        public int Geography_Misc
        {
            get { return geographyMisc; }
            set
            {
                geographyMisc = value;
                OnPropertyChanged("Geography_Misc");
            }
        }

        public int Geography_Total
        {
            get { return geographyTotal; }
            set
            {
                geographyTotal = value;
                OnPropertyChanged("Geography_Total");
            }
        }

        public int History_Rank
        {
            get { return historyRank; }
            set
            {
                historyRank = value;
                OnPropertyChanged("History_Rank");
            }
        }

        public int History_Misc
        {
            get { return historyMisc; }
            set
            {
                historyMisc = value;
                OnPropertyChanged("History_Misc");
            }
        }

        public int History_Total
        {
            get { return historyTotal; }
            set
            {
                historyTotal = value;
                OnPropertyChanged("History_Total");
            }
        }

        public int Local_Rank
        {
            get { return localRank; }
            set
            {
                localRank = value;
                OnPropertyChanged("Local_Rank");
            }
        }

        public int Local_Misc
        {
            get { return localMisc; }
            set
            {
                localMisc = value;
                OnPropertyChanged("Local_Misc");
            }
        }

        public int Local_Total
        {
            get { return localTotal; }
            set
            {
                localTotal = value;
                OnPropertyChanged("Local_Total");
            }
        }

        public int Nature_Rank
        {
            get { return natureRank; }
            set
            {
                natureRank = value;
                OnPropertyChanged("Nature_Rank");
            }
        }

        public int Nature_Misc
        {
            get { return natureMisc; }
            set
            {
                natureMisc = value;
                OnPropertyChanged("Nature_Misc");
            }
        }

        public int Nature_Total
        {
            get { return natureTotal; }
            set
            {
                natureTotal = value;
                OnPropertyChanged("Nature_Total");
            }
        }

        public int Nobility_Rank
        {
            get { return nobilityRank; }
            set
            {
                nobilityRank = value;
                OnPropertyChanged("Nobility_Rank");
            }
        }

        public int Nobility_Misc
        {
            get { return nobilityMisc; }
            set
            {
                nobilityMisc = value;
                OnPropertyChanged("Nobility_Misc");
            }
        }

        public int Nobility_Total
        {
            get { return nobilityTotal; }
            set
            {
                nobilityTotal = value;
                OnPropertyChanged("Nobility_Total");
            }
        }

        public int Planes_Rank
        {
            get { return planesRank; }
            set
            {
                planesRank = value;
                OnPropertyChanged("Planes_Rank");
            }
        }

        public int Planes_Misc
        {
            get { return planesMisc; }
            set
            {
                planesMisc = value;
                OnPropertyChanged("Planes_Misc");
            }
        }

        public int Planes_Total
        {
            get { return planesTotal; }
            set
            {
                planesTotal = value;
                OnPropertyChanged("Planes_Total");
            }
        }

        public int Religion_Rank
        {
            get { return religionRank; }
            set
            {
                religionRank = value;
                OnPropertyChanged("Religion_Rank");
            }
        }

        public int Religion_Misc
        {
            get { return religionMisc; }
            set
            {
                religionMisc = value;
                OnPropertyChanged("Religion_Misc");
            }
        }

        public int Religion_Total
        {
            get { return religionTotal; }
            set
            {
                religionTotal = value;
                OnPropertyChanged("Religion_Total");
            }
        }


        //CHARACTER BIO INFO

        public string CLASS_Name
        {
            get { return className; }

            set
            {
                className = value;
                OnPropertyChanged("CLASS_Name");
            }

        }

        public string PlayerName
        {
            get { return playerName; }
            set
            {
                playerName = value;
                OnPropertyChanged("PlayerName");
            }
        }

        public string CharacterName
        {
            get { return characterName; }
            set
            {
                characterName = value;
                OnPropertyChanged("CharacterName");
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

        internal void CalculateStrengthMod()
        {
            STR_MOD = (int)Math.Floor((str_score - 10.0f) / 2.0f);
        }

        internal void CalculateDexterityMod()
        {
            DEX_MOD = (int)Math.Floor((dex_score - 10.0f) / 2.0f);
        }

        internal void CalculateConstitutionMod()
        {
            CON_MOD = (int)Math.Floor((con_score - 10.0f) / 2.0f);
        }

        internal void CalculateIntelligenceMod()
        {
            INT_MOD = (int)Math.Floor((int_score - 10.0f) / 2.0f);
        }

        internal void CalculateWisdomMod()
        {
            WIS_MOD = (int)Math.Floor((wis_score - 10.0f) / 2.0f);
        }

        internal void CalculateCharismaMod()
        {
            CHA_MOD = (int)Math.Floor((cha_score - 10.0f) / 2.0f);
        }

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
            MAB_Total = baseAttackBonus + str_mod + meleeSizeBonus + meleeMiscBonus + meleeTempBonus;
        }

        internal void CalculateCMD()
        {
            CMD = 10 + baseAttackBonus + str_mod + dex_mod + combatManeuverSizeBonus + combatManeuverDefenseMisc;
        }

        internal void CalculateCMB()
        {
            CMB_Total = baseAttackBonus + str_mod + combatManeuverSizeBonus + combatManeuverMiscBonus + combatManeuverTempBonus;
        }

        internal void CalculateRAB()
        {
            RAB_Total = baseAttackBonus + dex_mod + rangeSizeBonus + rangeMiscBonus + rangeTempBonus;
        }

        internal void CalculateINIT()
        {
            INIT_Total = dex_mod + initMisc;
        }

        //SKILL CALCULATION METHODS

        internal void CalculateAcrobatics()
        {
            Acrobatics_Total = dex_mod + acrobaticsRank + acrobaticsMisc;
        }

        internal void CalculateAppraise()
        {
            Appraise_Total = int_mod + appraiseRank + appraiseMisc;
        }

        internal void CalculateBluff()
        {
            Bluff_Total = cha_mod + bluffRank + bluffMisc;
        }
        
        internal void CalculateClimb()
        {
            Climb_Total = str_mod + climbRank + climbMisc;
        }

        internal void CalculateCraft()
        {
            Craft_Total = int_mod + craftRank + craftMisc;
        }

        internal void CalculateDiplomacy()
        {
            Diplomacy_Total = cha_mod + diplomacyRank + diplomacyMisc;
        }

        internal void CalculateDisableDevice()
        {
            Disable_Device_Total = dex_mod + disableDeviceRank + disableDeviceMisc;
        }

        internal void CalculateDisguise()
        {
            Disguise_Total = cha_mod + disguiseRank + disguiseMisc;
        }

        internal void CalculateEscapeArtist()
        {
            Escape_Artist_Total = dex_mod + escapeArtistRank + escapeArtistMisc;
        }

        internal void CalculateFly()
        {
            Fly_Total = dex_mod + flyRank + flyMisc;
        }

        internal void CalculateHandleAnimal()
        {
            Handle_Animal_Total = cha_mod + handleAnimalRank + handleAnimalMisc;
        }

        internal void CalculateHeal()
        {
            Heal_Total = wis_mod + healRank + healMisc;
        }

        internal void CalculateIntimidate()
        {
            Intimidate_Total = cha_mod + intimidateRank + intimidateMisc;
        }

        internal void CalculateLinguistics()
        {
            Linguistics_Total = int_mod + linguisticsRank + linguisticsMisc;
        }

        internal void CalculatePerception()
        {
            Perception_Total = wis_mod + perceptionRank + perceptionMisc;
        }

        internal void CalculatePerform()
        {
            Perform_Total = cha_mod + performRank + performMisc;
        }

        internal void CalculateProfession()
        {
            Profession_Total = wis_mod + professionRank + professionMisc;
        }

        internal void CalculateRide()
        {
            Ride_Total = dex_mod + rideRank + rideMisc;
        }

        internal void CalculateSenseMotive()
        {
            Sense_Motive_Total = wis_mod + senseMotiveRank + senseMotiveMisc;
        }

        internal void CalculateSleightOfHand()
        {
            Sleight_Of_Hand_Total = dex_mod + sleightOfHandRank + sleightOfHandMisc;
        }

        internal void CalculateSpellcraft()
        {
            Spellcraft_Total = int_mod + spellcraftRank + spellcraftMisc;
        }

        internal void CalculateStealth()
        {
            Stealth_Total = dex_mod + stealthRank + stealthMisc;
        }

        internal void CalculateSurvival()
        {
            Survival_Total = wis_mod + survivalRank + survivalMisc;
        }

        internal void CalculateSwim()
        {
            Swim_Total = str_mod + swimRank + swimMisc;
        }

        internal void CalculateUseMagicDevice()
        {
            Use_Magic_Device_Total = cha_mod + useMagicDeviceRank + useMagicDeviceMisc;
        }

        internal void CalculateArcana()
        {
            Arcana_Total = int_mod + arcanaRank + arcanaMisc;
        }

        internal void CalculateDungeoneering()
        {
            Dungeoneering_Total = int_mod + dungeoneeringRank + dungeoneeringMisc;
        }

        internal void CalculateEngineering()
        {
            Engineering_Total = int_mod + engineeringRank + engineeringMisc;        
        }

        internal void CalculateGeography()
        {
            Geography_Total = int_mod + geographyRank + geographyMisc;
        }

        internal void CalculateHistory()
        {
            History_Total = int_mod + historyRank + historyMisc;
        }

        internal void CalculateLocal()
        {
            Local_Total = int_mod + localRank + localMisc;
        }

        internal void CalculateNature()
        {
            Nature_Total = int_mod + natureRank + natureMisc;
        }

        internal void CalculateNobility()
        {
            Nobility_Total = int_mod + nobilityRank + nobilityMisc;
        }

        internal void CalculatePlanes()
        {
            Planes_Total = int_mod + planesRank + planesMisc;
        }

        internal void CalculateReligion()
        {
            Religion_Total = int_mod + religionRank + religionMisc;
        }

        internal void calculateAllSkills()
        {
            CalculateAcrobatics();
            CalculateAppraise();
            CalculateBluff();
            CalculateClimb();
            CalculateCraft();
            CalculateDiplomacy();
            CalculateDisableDevice();
            CalculateDisguise();
            CalculateEscapeArtist();
            CalculateFly();
            CalculateHandleAnimal();
            CalculateHeal();
            CalculateIntimidate();
            CalculateLinguistics();
            CalculatePerception();
            CalculatePerform();
            CalculateProfession();
            CalculateRide();
            CalculateSenseMotive();
            CalculateSleightOfHand();
            CalculateSpellcraft();
            CalculateStealth();
            CalculateSurvival();
            CalculateSwim();
            CalculateUseMagicDevice();

            CalculateArcana();
            CalculateDungeoneering();
            CalculateEngineering();
            CalculateGeography();
            CalculateHistory();
            CalculateLocal();
            CalculateNature();
            CalculateNobility();
            CalculatePlanes();
            CalculateReligion();
        }

        #endregion
    }
}
