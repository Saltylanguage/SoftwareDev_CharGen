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
        public static bool LoadDialog(CharGenView model)
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

        public static bool FromJson(CharGenView model, JObject json)
        {
            //Load info
            model.CharacterName.Text = json.GetValue("Name").ToString();
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

            return true;
        }
    }
}
