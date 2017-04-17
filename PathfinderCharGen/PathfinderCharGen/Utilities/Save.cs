using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Views;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System.Windows.Media.Imaging;
using System.IO;

namespace PathfinderCharGen.Utilities
{
    public static class Save
    {
        private static string SavePath;

        public static string TheSavePath
        {
            set
            {
                SavePath = value;
            }
            get
            {
                return SavePath;
            }
        }

        public static bool SaveDialog(CharSheetView model)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json) [recomended]|*.json"; //|Xml file (*.xml)|*.xml
            saveFileDialog.InitialDirectory = TheSavePath;
            if (saveFileDialog.ShowDialog() == false)
            {
                return false;
            }

            return ToJson(model, saveFileDialog.FileName);
        }

        public static bool ToJson(CharSheetView model, string path)
        {
            //json object for storing data
            JObject json = new JObject();

            //Add char info to json
            json.Add("Player_Name", model.PlayerName.Text);
            json.Add("Char_Name", model.CharacterName.Text);
            json.Add("Race", model.CharacterRace.Text);
            json.Add("Class", model.CharacterClass.Text);
            json.Add("Level", model.CharacterLevel.Text);

            //Add health block to json
            json.Add("HP", model.HP.Text);
            json.Add("Max_HP", model.MaxHP.Text);
                       
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
           
            //AC
            json.Add("AC", model.AC.Text);
            json.Add("AC_Armor", model.AC_ArmorBonus.Text);           
            json.Add("AC_Dodge", model.AC_DodgeBonus.Text);
            json.Add("AC_Size", model.AC_SizeBonus.Text);
            json.Add("AC_Natural", model.AC_NaturalArmorBonus.Text);
            json.Add("AC_Deflect", model.AC_DeflectBonus.Text);
            json.Add("AC_Misc", model.AC_MiscBonus.Text);
            
            //Add Saves to json
            //Fort Save
            json.Add("FORT_Total", model.FORT_Total.Text);
            json.Add("FORT_Base",  model.FORT_Base.Text);
            json.Add("FORT_Magic", model.FORT_MagicBonus.Text);
            json.Add("FORT_Misc",  model.FORT_MiscBonus.Text);
            json.Add("FORT_Temp",  model.FORT_TempBonus.Text);
            //Ref Save
            json.Add("REF_Total", model.REF_Total.Text);
            json.Add("REF_Base",  model.REF_BaseBonus.Text);
            json.Add("REF_Magic", model.REF_MagicBonus.Text);
            json.Add("REF_Misc",  model.REF_MiscBonus.Text);
            json.Add("REF_Temp",  model.REF_TempBonus.Text);
            //Will Save
            json.Add("WILL_Total", model.WILL_Total.Text);
            json.Add("WILL_Base",  model.WILL_BaseBonus.Text);
            json.Add("WILL_Magic", model.WILL_MagicBonus.Text);
            json.Add("WILL_Misc",  model.WILL_MiscBonus.Text);
            json.Add("WILL_Temp",  model.WILL_Temp.Text);

            //Add Attack Bonuses to json            

            //MAB
            json.Add("MAB_Base",  model.MAB_Base.Text);
            json.Add("MAB_Total", model.MAB_Total.Text);
            json.Add("MAB_Size",  model.MAB_SizeBonus.Text);
            json.Add("MAB_Misc",  model.MAB_MiscBonus.Text);
            json.Add("MAB_Temp",  model.MAB_TempBonus.Text);
            //CMB
            json.Add("CMB_Base",  model.CMB_Base.Text);
            json.Add("CMB_Total", model.CMB_Total.Text);
            json.Add("CMB_Size",  model.CMB_SizeBonus.Text);
            json.Add("CMB_Misc",  model.CMB_MiscBonus.Text);
            json.Add("CMB_Temp",  model.CMB_TempBonus.Text);
            //RAB
            json.Add("RAB_Base",  model.RAB_Base.Text);
            json.Add("RAB_Total", model.RAB_Total.Text);
            json.Add("RAB_Size",  model.RAB_SizeBonus.Text);
            json.Add("RAB_Misc",  model.RAB_MiscBonus.Text);
            json.Add("RAB_Temp",  model.RAB_TempBonus.Text);

            //Init
            json.Add("INIT_Total", model.Init_Total.Text);
            json.Add("INIT_Misc",  model.Init_MiscBonus.Text);

            //Add more

            //Add Image
            BitmapSource src = model.CharImage.Source as BitmapSource;
            WriteableBitmap bitmap = new WriteableBitmap(src);
            int width = bitmap.PixelWidth;
            int height = bitmap.PixelHeight;
            int stride = width * ((bitmap.Format.BitsPerPixel + 7) / 8);
            double dpiX = bitmap.DpiX;
            double dpiY = bitmap.DpiY;
            string pixelFormat = bitmap.Format.ToString();
            byte[] bitmapData = new byte[height * stride];
            bitmap.CopyPixels(bitmapData, stride, 0);
            string byteString = Convert.ToBase64String(bitmapData);

            json.Add("ImageWidth", width.ToString());
            json.Add("ImageHeight", height.ToString());
            json.Add("ImageFormat", pixelFormat);
            json.Add("ImageDpiX", dpiX.ToString());
            json.Add("ImageDpiY", dpiY.ToString());
            json.Add("Image", byteString);

            System.IO.File.WriteAllText(path, json.ToString());

            return true;
        }
    }
}
