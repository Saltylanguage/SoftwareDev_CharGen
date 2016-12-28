using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for WizardStep4View.xaml
    /// </summary>
    public partial class WizardStep4View : UserControl
    {

        CharSheetView sheetView;

        private int numPoints = 0;

        public int NUM_POINTS
        {
            get { return numPoints; }
            set
            {
                numPoints = value;
                NumPoints.Text = value.ToString();
            }
        }

        private int strValue = 10;

        public int STR_VAL
        {
            get { return strValue; }
            set
            {
                strValue = value;
                STR_Score.Text = value.ToString();
            }
        }

        private int dexValue = 10;

        public int DEX_VAL
        {
            get { return dexValue; }
            set
            {
                dexValue = value;
                DEX_Score.Text = value.ToString();
            }
        }

        private int conValue = 10;

        public int CON_VAL
        {
            get { return conValue; }
            set
            {
                conValue = value;
                CON_Score.Text = value.ToString();
            }
        }

        private int intValue = 10;

        public int INT_VAL
        {
            get { return intValue; }
            set
            {
                intValue = value;
                INT_Score.Text = value.ToString();
            }
        }

        private int wisValue = 10;

        public int WIS_VAL
        {
            get { return wisValue; }
            set
            {
                wisValue = value;
                WIS_Score.Text = value.ToString();
            }
        }

        private int chaValue = 10;

        public int CHA_VAL
        {
            get { return chaValue; }
            set
            {
                chaValue = value;
                CHA_Score.Text = value.ToString();
            }
        }


        public WizardStep4View(CharSheetView SV)
        {
            sheetView = SV;
            InitializeComponent();
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            STR_Up.Command.Execute(this);
        }

        private void STR_Up_Click(object sender, RoutedEventArgs e)
        {
            if(NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (STR_VAL < 17)
            {
                if (STR_VAL < 8)
                {
                    STR_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (STR_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (STR_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (STR_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                STR_Up.IsEnabled = false;
            }
            STR_VAL++;
        }
        private void STR_Down_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (STR_VAL > 8)
            {
                if (STR_VAL > 17)
                {
                    STR_Up.IsEnabled = true;
                    NUM_POINTS += 4;
                }
                else if (STR_VAL > 15)
                {
                    NUM_POINTS += 3;
                }
                else if (STR_VAL > 13)
                {
                    NUM_POINTS += 2;
                }
                else if (STR_VAL > 8)
                {
                    NUM_POINTS += 1;
                }
            }
            else
            {
                NUM_POINTS += 2;
                STR_Down.IsEnabled = false;
            }

            STR_VAL--;
        }

        private void DEX_Up_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (DEX_VAL < 17)
            {
                if (DEX_VAL < 8)
                {
                    DEX_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (DEX_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (DEX_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (DEX_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                DEX_Up.IsEnabled = false;
            }
            DEX_VAL++;
        }
        private void DEX_Down_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (DEX_VAL > 8)
            {
                if (DEX_VAL > 17)
                {
                    DEX_Up.IsEnabled = true;
                    NUM_POINTS += 4;
                }
                else if (DEX_VAL > 15)
                {
                    NUM_POINTS += 3;
                }
                else if (DEX_VAL > 13)
                {
                    NUM_POINTS += 2;
                }
                else if (DEX_VAL > 8)
                {
                    NUM_POINTS += 1;
                }
            }
            else
            {
                NUM_POINTS += 2;
                DEX_Down.IsEnabled = false;
            }
            DEX_VAL--;
        }

        private void CON_Up_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (CON_VAL < 17)
            {
                if (CON_VAL < 8)
                {
                    CON_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (CON_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (CON_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (CON_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                CON_Up.IsEnabled = false;
            }
            CON_VAL++;
        }
        private void CON_Down_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (CON_VAL > 17)
            {
                CON_Up.IsEnabled = true;
                NUM_POINTS += 4;
            }
            else if (CON_VAL > 15)
            {
                NUM_POINTS += 3;
            }
            else if (CON_VAL > 13)
            {
                NUM_POINTS += 2;
            }
            else if (CON_VAL > 8)
            {
                NUM_POINTS += 1;
            }

            else
            {
                NUM_POINTS += 2;
                CON_Down.IsEnabled = false;
            }
            CON_VAL--;
        }

        private void INT_Up_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (INT_VAL < 17)
            {
                if (INT_VAL < 8)
                {
                    INT_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (INT_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (INT_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (INT_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                INT_Up.IsEnabled = false;
            }
            INT_VAL++;
        }

        private void INT_Down_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (INT_VAL > 17)
            {
                INT_Up.IsEnabled = true;
                NUM_POINTS += 4;
            }
            else if (INT_VAL > 15)
            {
                NUM_POINTS += 3;
            }
            else if (INT_VAL > 13)
            {
                NUM_POINTS += 2;
            }
            else if (INT_VAL > 8)
            {
                NUM_POINTS += 1;
            }

            else
            {
                NUM_POINTS += 2;
                INT_Down.IsEnabled = false;
            }
            INT_VAL--;
        }

        private void WIS_Up_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (WIS_VAL < 17)
            {
                if (WIS_VAL < 8)
                {
                    WIS_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (WIS_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (WIS_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (WIS_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                WIS_Up.IsEnabled = false;
            }
            WIS_VAL++;
        }

        private void WIS_Down_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (WIS_VAL > 17)
            {
                WIS_Up.IsEnabled = true;
                NUM_POINTS += 4;
            }
            else if (WIS_VAL > 15)
            {
                NUM_POINTS += 3;
            }
            else if (WIS_VAL > 13)
            {
                NUM_POINTS += 2;
            }
            else if (WIS_VAL > 8)
            {
                NUM_POINTS += 1;
            }
            else
            {
                NUM_POINTS += 2;
                WIS_Down.IsEnabled = false;
            }
            WIS_VAL--;
        }

        private void CHA_Up_Click(object sender, RoutedEventArgs e)
        {
            if (NUM_POINTS <= 1)
            {
                STR_Up.IsEnabled = false;
                DEX_Up.IsEnabled = false;
                CON_Up.IsEnabled = false;
                INT_Up.IsEnabled = false;
                WIS_Up.IsEnabled = false;
                CHA_Up.IsEnabled = false;
            }
            if (CHA_VAL < 17)
            {
                if (CHA_VAL < 8)
                {
                    CHA_Down.IsEnabled = true;
                    NUM_POINTS -= 2;
                }
                else if (CHA_VAL < 13)
                {
                    NUM_POINTS -= 1;
                }
                else if (CHA_VAL < 15)
                {
                    NUM_POINTS -= 2;
                }
                else if (CHA_VAL < 17)
                {
                    NUM_POINTS -= 3;
                }
            }
            else
            {
                NUM_POINTS -= 4;
                CHA_Up.IsEnabled = false;
            }
            CHA_VAL++;
        }

        private void CHA_Down_Click(object sender, RoutedEventArgs e)
        {

            if (NUM_POINTS >= 0)
            {
                STR_Up.IsEnabled = true;
                DEX_Up.IsEnabled = true;
                CON_Up.IsEnabled = true;
                INT_Up.IsEnabled = true;
                WIS_Up.IsEnabled = true;
                CHA_Up.IsEnabled = true;
            }
            if (CHA_VAL > 17)
            {
                CHA_Up.IsEnabled = true;
                NUM_POINTS += 4;
            }
            else if (CHA_VAL > 15)
            {
                NUM_POINTS += 3;
            }
            else if (CHA_VAL > 13)
            {
                NUM_POINTS += 2;
            }
            else if (CHA_VAL > 8)
            {
                NUM_POINTS += 1;
            }

            else
            {
                NUM_POINTS += 2;
                CHA_Down.IsEnabled = false;
            }
            CHA_VAL--;
        }

        private void Step4Next_Click(object sender, RoutedEventArgs e)
        {
            sheetView.STR_Score.Text = STR_Score.Text;
            sheetView.DEX_Score.Text = DEX_Score.Text;
            sheetView.CON_Score.Text = CON_Score.Text;
            sheetView.INT_Score.Text = INT_Score.Text;
            sheetView.WIS_Score.Text = WIS_Score.Text;
            sheetView.CHA_Score.Text = CHA_Score.Text;

            int strMod = (Convert.ToInt32(STR_Score.Text) - 10) / 2;
            int dexMod = (Convert.ToInt32(DEX_Score.Text) - 10) / 2;
            int conMod = (Convert.ToInt32(CON_Score.Text) - 10) / 2;
            int intMod = (Convert.ToInt32(INT_Score.Text) - 10) / 2;
            int wisMod = (Convert.ToInt32(WIS_Score.Text) - 10) / 2;
            int chaMod = (Convert.ToInt32(CHA_Score.Text) - 10) / 2;

            sheetView.STR_Mod.Text = strMod.ToString();
            sheetView.DEX_Mod.Text = dexMod.ToString();
            sheetView.CON_Mod.Text = conMod.ToString();
            sheetView.INT_Mod.Text = intMod.ToString();
            sheetView.WIS_Mod.Text = wisMod.ToString();
            sheetView.CHA_Mod.Text = chaMod.ToString();

            sheetView.CharacterLevel.Text = "1";

            this.Content = new WizardStep5View(sheetView);
        }

        private void EpicFantasy_Click(object sender, RoutedEventArgs e)
        {
            NUM_POINTS = 25;

            STR_VAL = 10;
            DEX_VAL = 10;
            CON_VAL = 10;
            INT_VAL = 10;
            WIS_VAL = 10;
            CHA_VAL = 10;

            STR_Up.IsEnabled = true;
            DEX_Up.IsEnabled = true;
            CON_Up.IsEnabled = true;
            INT_Up.IsEnabled = true;
            WIS_Up.IsEnabled = true;
            CHA_Up.IsEnabled = true;

            STR_Down.IsEnabled = true;
            DEX_Down.IsEnabled = true;
            CON_Down.IsEnabled = true;
            INT_Down.IsEnabled = true;
            WIS_Down.IsEnabled = true;
            CHA_Down.IsEnabled = true;

        }

        private void HighFantasy_Click(object sender, RoutedEventArgs e)
        {
            NUM_POINTS = 15;

            STR_VAL = 10;
            DEX_VAL = 10;
            CON_VAL = 10;
            INT_VAL = 10;
            WIS_VAL = 10;
            CHA_VAL = 10;

            STR_Up.IsEnabled = true;
            DEX_Up.IsEnabled = true;
            CON_Up.IsEnabled = true;
            INT_Up.IsEnabled = true;
            WIS_Up.IsEnabled = true;
            CHA_Up.IsEnabled = true;

            STR_Down.IsEnabled = true;
            DEX_Down.IsEnabled = true;
            CON_Down.IsEnabled = true;
            INT_Down.IsEnabled = true;
            WIS_Down.IsEnabled = true;
            CHA_Down.IsEnabled = true;
        }

        private void LowFantasy_Click(object sender, RoutedEventArgs e)
        {
            NUM_POINTS = 10;

            STR_VAL = 10;
            DEX_VAL = 10;
            CON_VAL = 10;
            INT_VAL = 10;
            WIS_VAL = 10;
            CHA_VAL = 10;

            STR_Up.IsEnabled = true;
            DEX_Up.IsEnabled = true;
            CON_Up.IsEnabled = true;
            INT_Up.IsEnabled = true;
            WIS_Up.IsEnabled = true;
            CHA_Up.IsEnabled = true;

            STR_Down.IsEnabled = true;
            DEX_Down.IsEnabled = true;
            CON_Down.IsEnabled = true;
            INT_Down.IsEnabled = true; 
            WIS_Down.IsEnabled = true;
            CHA_Down.IsEnabled = true;
        }
    }
}
