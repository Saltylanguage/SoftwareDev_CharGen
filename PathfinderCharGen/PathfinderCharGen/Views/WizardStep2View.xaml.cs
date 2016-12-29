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
    }
}
