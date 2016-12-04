using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Views;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;

namespace PathfinderCharGen.Utilities
{
    public static class Load
    {
        public static bool LoadDialog(CharSheetView model)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json file (*.json)|*.json";
            if (openFileDialog.ShowDialog() == false)
            {
                return false;
            }

            JObject json = JObject.Parse(System.IO.File.ReadAllText(openFileDialog.FileName));

            return FromJson(model, json);
        }

        public static bool FromJson(CharSheetView model, JObject json)
        {
            //Load info
            model.PlayerName.Text = json.GetValue("Player_Name").ToString();
            model.CharacterName.Text = json.GetValue("Char_Name").ToString();
            model.CharacterRace.Text = json.GetValue("Race").ToString();
            model.CharacterClass.Text = json.GetValue("Class").ToString();
            model.CharacterLevel.Text = json.GetValue("Level").ToString();

            //Load health
            model.HP.Text = json.GetValue("HP").ToString();
            model.MaxHP.Text = json.GetValue("Max_HP").ToString();
            model.AC.Text = json.GetValue("AC").ToString();

            //Load stat block
            model.STR_Score.Text = json.GetValue("STR").ToString();
            model.DEX_Score.Text = json.GetValue("DEX").ToString();
            model.CON_Score.Text = json.GetValue("CON").ToString();
            model.INT_Score.Text = json.GetValue("INT").ToString();
            model.WIS_Score.Text = json.GetValue("WIS").ToString();
            model.CHA_Score.Text = json.GetValue("CHA").ToString();

            //Load AC Stats
            model.AC.Text = json.GetValue("AC").ToString();
            model.AC_ArmorBonus.Text = json.GetValue("AC_Armor").ToString();          
            model.AC_DodgeBonus.Text = json.GetValue("AC_Dodge").ToString();
            model.AC_SizeBonus.Text = json.GetValue("AC_Size").ToString();
            model.AC_NaturalArmorBonus.Text = json.GetValue("AC_Natural").ToString();
            model.AC_DeflectBonus.Text = json.GetValue("AC_Deflect").ToString();
            model.AC_MiscBonus.Text = json.GetValue("AC_Misc").ToString();

            //Load Fort Stats
            model.FORT_Total.Text = json.GetValue("FORT_Total").ToString();
            model.FORT_Base.Text = json.GetValue("FORT_Base").ToString();
            model.FORT_MagicBonus.Text = json.GetValue("FORT_Magic").ToString();
            model.FORT_MiscBonus.Text = json.GetValue("FORT_Misc").ToString();
            model.FORT_TempBonus.Text = json.GetValue("FORT_Temp").ToString();

            //Load Ref Stats
            model.REF_Total.Text = json.GetValue("REF_Total").ToString();
            model.REF_BaseBonus.Text = json.GetValue("REF_Base").ToString();
            model.REF_MagicBonus.Text = json.GetValue("REF_Magic").ToString();
            model.REF_MiscBonus.Text = json.GetValue("REF_Misc").ToString();
            model.REF_TempBonus.Text = json.GetValue("REF_Temp").ToString();

            //Load Will Stats
            model.WILL_Total.Text = json.GetValue("WILL_Total").ToString();
            model.WILL_BaseBonus.Text = json.GetValue("WILL_Base").ToString();
            model.WILL_MagicBonus.Text = json.GetValue("WILL_Magic").ToString();
            model.WILL_MiscBonus.Text = json.GetValue("WILL_Misc").ToString();
            model.WILL_Temp.Text = json.GetValue("WILL_Temp").ToString();

            //Load MAB Stats
            model.MAB_Base.Text = json.GetValue("MAB_Base").ToString();
            model.MAB_Total.Text = json.GetValue("MAB_Total").ToString();
            model.MAB_SizeBonus.Text = json.GetValue("MAB_Size").ToString();
            model.MAB_MiscBonus.Text = json.GetValue("MAB_Misc").ToString();
            model.MAB_TempBonus.Text = json.GetValue("MAB_Temp").ToString();

            //Load CMB Stats
            model.CMB_Base.Text = json.GetValue("CMB_Base").ToString();
            model.CMB_Total.Text = json.GetValue("CMB_Total").ToString();
            model.CMB_SizeBonus.Text = json.GetValue("CMB_Size").ToString();
            model.CMB_MiscBonus.Text = json.GetValue("CMB_Misc").ToString();
            model.CMB_TempBonus.Text = json.GetValue("CMB_Temp").ToString();

            //Load RAB Stats
            model.RAB_Base.Text = json.GetValue("RAB_Base").ToString();
            model.RAB_Total.Text = json.GetValue("RAB_Total").ToString();
            model.RAB_SizeBonus.Text = json.GetValue("RAB_Size").ToString();
            model.RAB_MiscBonus.Text = json.GetValue("RAB_Misc").ToString();
            model.RAB_TempBonus.Text = json.GetValue("RAB_Temp").ToString();
                   
            return true;
        }
    }
}
