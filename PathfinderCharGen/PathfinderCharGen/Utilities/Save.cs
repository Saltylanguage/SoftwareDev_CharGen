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
    public static class Save
    {
        public static bool SaveDialog(CharGenView model)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json) [recomended]|*.json"; //|Xml file (*.xml)|*.xml
            if (saveFileDialog.ShowDialog() == false)
            {
                return false;
            }

            return ToJson(model, saveFileDialog.FileName);
        }

        public static bool ToJson(CharGenView model, string path)
        {
            //json object for storing data
            JObject json = new JObject();

            //Add char info to json
            json.Add("Name", model.CharacterName.Text);
            json.Add("Race", model.CharacterRace.Text);
            json.Add("Class", model.CharacterClass.Text);
            json.Add("Level", model.CharacterLevel.Text);

            //Add health block to json
            json.Add("HP", model.HP.Text);
            json.Add("Max_HP", model.MaxHP.Text);
            json.Add("AC", model.AC.Text);
            
            //Add stat block to json
            //STR
            json.Add("STR", model.STR_Score.Text);
            json.Add("STR_Mod", model.STR_Mod.Text);
            json.Add("STR_Temp", model.STR_TempScore.Text);
            json.Add("STR_Temp_Mod", model.STR_TempMod.Text);
            //DEX
            json.Add("DEX", model.DEX_Score.Text);
            json.Add("DEX_Mod", model.DEX_Mod.Text);
            json.Add("DEX_Temp", model.DEX_TempScore.Text);
            json.Add("DEX_Temp_Mod", model.DEX_TempMod.Text);
            //CON
            json.Add("CON", model.CON_Score.Text);
            json.Add("CON_Mod", model.CON_Mod.Text);
            json.Add("CON_Temp", model.CON_TempScore.Text);
            json.Add("CON_Temp_Mod", model.CON_TempMod.Text);
            //INT
            json.Add("INT", model.INT_Score.Text);
            json.Add("INT_Mod", model.INT_Mod.Text);
            json.Add("INT_Temp", model.INT_TempScore.Text);
            json.Add("INT_Temp_Mod", model.INT_TempMod.Text);
            //WIS
            json.Add("WIS", model.WIS_Score.Text);
            json.Add("WIS_Mod", model.WIS_Mod.Text);
            json.Add("WIS_Temp", model.WIS_TempScore.Text);
            json.Add("WIS_Temp_Mod", model.WIS_TempMod.Text);
            //CHA
            json.Add("CHA", model.CHA_Score.Text);
            json.Add("CHA_Mod", model.CHA_Mod.Text);
            json.Add("CHA_Temp", model.CHA_TempScore.Text);
            json.Add("CHA_Temp_Mod", model.CHA_TempMod.Text);

            //Add more

            System.IO.File.WriteAllText(path, json.ToString());

            return true;
        }
    }
}
