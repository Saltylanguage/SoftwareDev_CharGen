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
using System.Globalization;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for WizardStep2View.xaml
    /// </summary>
    public partial class WizardStep2View : UserControl
    {
        CharSheetView sheetView;

        public WizardStep2View(CharSheetView SV)
        {
            InitializeComponent();
            sheetView = SV;
        }

        private void Step2Next_Click(object sender, RoutedEventArgs e)
        {
            sheetView.CharacterRace.Text = RaceSelection.Text.ToString();
            sheetView.character.ChooseRace(RaceSelection.Text.ToString());
            this.Content = new WizardStep3View(sheetView);
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            string testString = "This is some text. Testing to see if text will render.  If text renders, replace text with physical description of each race.";

            //Create formatted text object
            FormattedText testFormattedText = new FormattedText(
                    testString,
                    CultureInfo.GetCultureInfo("en-us"),
                    FlowDirection.LeftToRight,
                    new Typeface("Verdana"),
                    32,
                    Brushes.Black);

            //set max width and height, elipses("...") will be shown if text exceeds these values
            testFormattedText.MaxTextWidth = 300;
            testFormattedText.MaxTextHeight = 240;

            testFormattedText.SetFontSize(36);

            testFormattedText.SetForegroundBrush(
                new LinearGradientBrush(
                    Colors.Orange,
                    Colors.Teal,
                    90.0),
                    6, 11);

            testFormattedText.SetFontStyle(FontStyles.Italic, 20, 20);
                      
            drawingContext.DrawText(testFormattedText, new Point(25, 300));            
        }

        private void RaceSelection_MouseEnter(object sender, MouseEventArgs e)
        {
            sheetView.character.statMgr.raceMgr.RaceSelector(RaceSelection.Text);

            STR_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceStr.ToString();
            DEX_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceDex.ToString();
            CON_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceCon.ToString();
            INT_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceItl.ToString();
            WIS_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceWis.ToString();
            CHA_Race.Text = sheetView.character.statMgr.raceMgr.Race.RaceCha.ToString();

            if(RaceSelection.Text.Contains("Half-") || RaceSelection.Text == "Human")
            {
                VariableBonusTextBlock.Visibility = System.Windows.Visibility.Visible;
                VariableBonusComboBox.Visibility = System.Windows.Visibility.Visible;
                VariableBonusTextBlock.IsEnabled = true;
                VariableBonusComboBox.IsEnabled = true;
                
            }
            else
            {
                VariableBonusTextBlock.Visibility = System.Windows.Visibility.Hidden;
                VariableBonusComboBox.Visibility = System.Windows.Visibility.Hidden;
                VariableBonusTextBlock.IsEnabled = false;
                VariableBonusComboBox.IsEnabled = false;
                VariableBonusComboBox.Text = "";
            }
        }

        private void VariableBonusComboBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (VariableBonusComboBox.Text == "STR")
            {
                STR_Race.Text = "2";
                DEX_Race.Text = "0";
                CON_Race.Text = "0";
                INT_Race.Text = "0";
                WIS_Race.Text = "0";
                CHA_Race.Text = "0";

                sheetView.character.statMgr.raceMgr.Race.RaceStr = 2;

            }
            if (VariableBonusComboBox.Text == "DEX")
            {
                STR_Race.Text = "0";
                DEX_Race.Text = "2";
                CON_Race.Text = "0";
                INT_Race.Text = "0";
                WIS_Race.Text = "0";
                CHA_Race.Text = "0";

                sheetView.character.statMgr.raceMgr.Race.RaceDex = 2;
            }
            if (VariableBonusComboBox.Text == "CON")
            {
                STR_Race.Text = "0";
                DEX_Race.Text = "0";
                CON_Race.Text = "2";
                INT_Race.Text = "0";
                WIS_Race.Text = "0";
                CHA_Race.Text = "0";

                sheetView.character.statMgr.raceMgr.Race.RaceCon = 2;
            }
            if (VariableBonusComboBox.Text == "INT")
            {
                STR_Race.Text = "0";
                DEX_Race.Text = "0";
                CON_Race.Text = "0";
                INT_Race.Text = "2";
                WIS_Race.Text = "0";
                CHA_Race.Text = "0";

                sheetView.character.statMgr.raceMgr.Race.RaceItl = 2;
            }
            if (VariableBonusComboBox.Text == "WIS")
            {
                STR_Race.Text = "0";
                DEX_Race.Text = "0";
                CON_Race.Text = "0";
                INT_Race.Text = "0";
                WIS_Race.Text = "2";
                CHA_Race.Text = "0";

                sheetView.character.statMgr.raceMgr.Race.RaceWis = 2;
            }
            if (VariableBonusComboBox.Text == "CHA")
            {
                STR_Race.Text = "0";
                DEX_Race.Text = "0";
                CON_Race.Text = "0";
                INT_Race.Text = "0";
                WIS_Race.Text = "0";
                CHA_Race.Text = "2";

                sheetView.character.statMgr.raceMgr.Race.RaceCha = 2;
            }

        }
    }
}
