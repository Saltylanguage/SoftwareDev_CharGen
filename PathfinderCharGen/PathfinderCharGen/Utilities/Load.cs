using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Views;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.IO;
using System.Windows.Threading;

namespace PathfinderCharGen.Utilities
{
    public static class Load
    {
        public static bool LoadDialog(CharSheetView model)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json file (*.json)|*.json";
            openFileDialog.InitialDirectory = Save.TheSavePath;
            if (openFileDialog.ShowDialog() == false)
            {
                return false;
            }

            JObject json = JObject.Parse(System.IO.File.ReadAllText(openFileDialog.FileName));

            return FromJson(model, json);
        }

        public static bool FromJson(CharSheetView model, JObject json)
        {
            JToken temp = "";

            //Load info
            if (json.TryGetValue("Player_Name", out temp)) model.PlayerName.Text = temp.ToString();
            else model.PlayerName.Text = "";
            if (json.TryGetValue("Char_Name", out temp)) model.CharacterName.Text = temp.ToString();
            else model.CharacterName.Text = "";
            if (json.TryGetValue("Race", out temp)) model.CharacterRace.Text = temp.ToString();
            else model.CharacterRace.Text = "";
            if (json.TryGetValue("Class", out temp)) model.CharacterClass.Text = temp.ToString();
            else model.CharacterClass.Text = "";
            if (json.TryGetValue("Level", out temp)) model.CharacterLevel.Text = temp.ToString();
            else model.CharacterLevel.Text = "";

            //Load health
            if (json.TryGetValue("HP", out temp)) model.HP.Text = temp.ToString();
            else model.HP.Text = "";
            if (json.TryGetValue("Max_HP", out temp)) model.MaxHP.Text = temp.ToString();
            else model.MaxHP.Text = "";
            if (json.TryGetValue("AC", out temp)) model.AC.Text = temp.ToString();
            else model.AC.Text = "";

            //Load stat block
            if (json.TryGetValue("STR", out temp)) model.STR_Score.Text = temp.ToString();
            else model.STR_Score.Text = "";
            if (json.TryGetValue("DEX", out temp)) model.DEX_Score.Text = temp.ToString();
            else model.DEX_Score.Text = "";
            if (json.TryGetValue("CON", out temp)) model.CON_Score.Text = temp.ToString();
            else model.CON_Score.Text = "";
            if (json.TryGetValue("INT", out temp)) model.INT_Score.Text = temp.ToString();
            else model.INT_Score.Text = "";
            if (json.TryGetValue("WIS", out temp)) model.WIS_Score.Text = temp.ToString();
            else model.WIS_Score.Text = "";
            if (json.TryGetValue("CHA", out temp)) model.CHA_Score.Text = temp.ToString();
            else model.CHA_Score.Text = "";

            //Load AC Stats
            if (json.TryGetValue("AC", out temp)) model.AC.Text = temp.ToString();
            else model.AC.Text = "";
            if (json.TryGetValue("AC_Armor", out temp)) model.AC_ArmorBonus.Text = temp.ToString();
            else model.AC_ArmorBonus.Text = "";
            if (json.TryGetValue("AC_Dodge", out temp)) model.AC_DodgeBonus.Text = temp.ToString();
            else model.AC_DodgeBonus.Text = "";
            if (json.TryGetValue("AC_Size", out temp)) model.AC_SizeBonus.Text = temp.ToString();
            else model.AC_SizeBonus.Text = "";
            if (json.TryGetValue("AC_Natural", out temp)) model.AC_NaturalArmorBonus.Text = temp.ToString();
            else model.AC_NaturalArmorBonus.Text = "";
            if (json.TryGetValue("AC_Deflect", out temp)) model.AC_DeflectBonus.Text = temp.ToString();
            else model.AC_DeflectBonus.Text = "";
            if (json.TryGetValue("AC_Misc", out temp)) model.AC_MiscBonus.Text = temp.ToString();
            else model.AC_MiscBonus.Text = "";

            //Load Fort Stats
            if (json.TryGetValue("FORT_Total", out temp)) model.FORT_Total.Text = temp.ToString();
            else model.FORT_Total.Text = "";
            if (json.TryGetValue("FORT_Base", out temp)) model.FORT_Base.Text = temp.ToString();
            else model.FORT_Base.Text = "";
            if (json.TryGetValue("FORT_Magic", out temp)) model.FORT_MagicBonus.Text = temp.ToString();
            else model.FORT_MagicBonus.Text = "";
            if (json.TryGetValue("FORT_Misc", out temp)) model.FORT_MiscBonus.Text = temp.ToString();
            else model.FORT_MiscBonus.Text = "";
            if (json.TryGetValue("FORT_Temp", out temp)) model.FORT_TempBonus.Text = temp.ToString();
            else model.FORT_TempBonus.Text = "";

            //Load Ref Stats
            if (json.TryGetValue("REF_Total", out temp)) model.REF_Total.Text = temp.ToString();
            else model.REF_Total.Text = "";
            if (json.TryGetValue("REF_Base", out temp)) model.REF_BaseBonus.Text = temp.ToString();
            else model.REF_BaseBonus.Text = "";
            if (json.TryGetValue("REF_Magic", out temp)) model.REF_MagicBonus.Text = temp.ToString();
            else model.REF_MagicBonus.Text = "";
            if (json.TryGetValue("REF_Misc", out temp)) model.REF_MiscBonus.Text = temp.ToString();
            else model.REF_MiscBonus.Text = "";
            if (json.TryGetValue("REF_Temp", out temp)) model.REF_TempBonus.Text = temp.ToString();
            else model.REF_TempBonus.Text = "";

            //Load Will Stats
            if (json.TryGetValue("WILL_Total", out temp)) model.WILL_Total.Text = temp.ToString();
            else model.WILL_Total.Text = "";
            if (json.TryGetValue("WILL_Base", out temp)) model.WILL_BaseBonus.Text = temp.ToString();
            else model.WILL_BaseBonus.Text = "";
            if (json.TryGetValue("WILL_Magic", out temp)) model.WILL_MagicBonus.Text = temp.ToString();
            else model.WILL_MagicBonus.Text = "";
            if (json.TryGetValue("WILL_Misc", out temp)) model.WILL_MiscBonus.Text = temp.ToString();
            else model.WILL_MiscBonus.Text = "";
            if (json.TryGetValue("WILL_Temp", out temp)) model.WILL_Temp.Text = temp.ToString();
            else model.WILL_Temp.Text = "";

            //Load MAB Stats
            if (json.TryGetValue("MAB_Base", out temp)) model.MAB_Base.Text = temp.ToString();
            else model.MAB_Base.Text = "";
            if (json.TryGetValue("MAB_Total", out temp)) model.MAB_Total.Text = temp.ToString();
            else model.MAB_Total.Text = "";
            if (json.TryGetValue("MAB_Size", out temp)) model.MAB_SizeBonus.Text = temp.ToString();
            else model.MAB_SizeBonus.Text = "";
            if (json.TryGetValue("MAB_Misc", out temp)) model.MAB_MiscBonus.Text = temp.ToString();
            else model.MAB_MiscBonus.Text = "";
            if (json.TryGetValue("MAB_Temp", out temp)) model.MAB_TempBonus.Text = temp.ToString();
            else model.MAB_TempBonus.Text = "";

            //Load CMB Stats
            if (json.TryGetValue("CMB_Base", out temp)) model.CMB_Base.Text = temp.ToString();
            else model.CMB_Base.Text = "";
            if (json.TryGetValue("CMB_Total", out temp)) model.CMB_Total.Text = temp.ToString();
            else model.CMB_Total.Text = "";
            if (json.TryGetValue("CMB_Size", out temp)) model.CMB_SizeBonus.Text = temp.ToString();
            else model.CMB_SizeBonus.Text = "";
            if (json.TryGetValue("CMB_Misc", out temp)) model.CMB_MiscBonus.Text = temp.ToString();
            else model.CMB_MiscBonus.Text = "";
            if (json.TryGetValue("CMB_Temp", out temp)) model.CMB_TempBonus.Text = temp.ToString();
            else model.CMB_TempBonus.Text = "";

            //Load RAB Stats
            if (json.TryGetValue("RAB_Base", out temp)) model.RAB_Base.Text = temp.ToString();
            else model.RAB_Base.Text = "";
            if (json.TryGetValue("RAB_Total", out temp)) model.RAB_Total.Text = temp.ToString();
            else model.RAB_Total.Text = "";
            if (json.TryGetValue("RAB_Size", out temp)) model.RAB_SizeBonus.Text = temp.ToString();
            else model.RAB_SizeBonus.Text = "";
            if (json.TryGetValue("RAB_Misc", out temp)) model.RAB_MiscBonus.Text = temp.ToString();
            else model.RAB_MiscBonus.Text = "";
            if (json.TryGetValue("RAB_Temp", out temp)) model.RAB_TempBonus.Text = temp.ToString();
            else model.RAB_TempBonus.Text = "";

            //Load class tab
            model.setClassTab();
            model.ClassTab.Header = model.CharacterClass.Text;

            //Load Image
            Action action = delegate ()
            {
                ImageProcess(model, json);
            };

            Dispatcher jeff;
            jeff = Dispatcher.CurrentDispatcher;
            jeff.Invoke(DispatcherPriority.Normal, action);

            return true;
        }

        public static void ImageProcess(CharSheetView model, JObject json)
        {
            JToken temp = "";

            bool valid = true;
            int width = -1, height = -1, bytesPerPixel = -1, stride = -1;
            double dpiX = -1, dpiY = -1;
            PixelFormat pixelFormat = PixelFormats.Default;
            byte[] bitmapData = null;

            if (valid && json.TryGetValue("ImageWidth", out temp)) width = Convert.ToInt32(temp.ToString());
            else valid = false;
            if (valid && json.TryGetValue("ImageHeight", out temp)) height = Convert.ToInt32(temp.ToString());
            else valid = false;
            if (valid && json.TryGetValue("ImageFormat", out temp)) pixelFormat = PixelFromatFromString(temp.ToString());
            else valid = false;
            if (valid && json.TryGetValue("ImageDpiX", out temp)) dpiX = Convert.ToDouble(temp.ToString());
            else valid = false;
            if (valid && json.TryGetValue("ImageDpiY", out temp)) dpiY = Convert.ToDouble(temp.ToString());
            else valid = false;
            if (valid && json.TryGetValue("Image", out temp)) bitmapData = Convert.FromBase64String(temp.ToString());
            else valid = false;

            if (valid)
            {
                bytesPerPixel = (pixelFormat.BitsPerPixel + 7) / 8;
                stride = bytesPerPixel * width;
                BitmapSource bitmap = BitmapSource.Create(width, height, dpiX, dpiY, pixelFormat, null, bitmapData, stride);
                model.CharImage.Source = bitmap;
            }
        }

        public static bool LoadPic(CharSheetView model)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == false)
            {
                return false;
            }

            model.CharImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));

            return true;
        }

        private static PixelFormat PixelFromatFromString(string input)
        {
            switch (input)
            {
                case "Bgr101010":
                    return PixelFormats.Bgr101010;
                case "Bgr24":
                    return PixelFormats.Bgr24;
                case "Bgr32":
                    return PixelFormats.Bgr32;
                case "Bgr555":
                    return PixelFormats.Bgr555;
                case "Bgr565":
                    return PixelFormats.Bgr565;
                case "Bgra32":
                    return PixelFormats.Bgra32;
                case "BlackWhite":
                    return PixelFormats.BlackWhite;
                case "Cmyk32":
                    return PixelFormats.Cmyk32;
                case "Default":
                    return PixelFormats.Default;
                case "Gray16":
                    return PixelFormats.Gray16;
                case "Gray2":
                    return PixelFormats.Gray2;
                case "Gray32Float":
                    return PixelFormats.Gray32Float;
                case "Gray4":
                    return PixelFormats.Gray4;
                case "Gray8":
                    return PixelFormats.Gray8;
                case "Indexed1":
                    return PixelFormats.Indexed1;
                case "Indexed2":
                    return PixelFormats.Indexed2;
                case "Indexed4":
                    return PixelFormats.Indexed4;
                case "Indexed8":
                    return PixelFormats.Indexed8;
                case "Pbgra32":
                    return PixelFormats.Pbgra32;
                case "Prgba64":
                    return PixelFormats.Prgba64;
                case "Rgb128Float":
                    return PixelFormats.Rgb128Float;
                case "Rgb24":
                    return PixelFormats.Rgb24;
                case "Rgb48":
                    return PixelFormats.Rgb48;
                case "Rgba128Float":
                    return PixelFormats.Rgba128Float;
                case "Rgba64":
                    return PixelFormats.Rgba64;
                default:
                    return PixelFormats.Default;
            }
        }
    }
}
