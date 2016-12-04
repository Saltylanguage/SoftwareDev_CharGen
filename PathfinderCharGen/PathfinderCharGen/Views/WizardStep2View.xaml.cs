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
    /// Interaction logic for WizardStep2View.xaml
    /// </summary>
    public partial class WizardStep2View : UserControl
    {

        CharSheetView sheetView;

        public WizardStep2View(CharSheetView SV)
        {
            sheetView = SV;
            InitializeComponent();
        }

        private void Step2Next_Click(object sender, RoutedEventArgs e)
        {
            sheetView.CharacterRace.Text = RaceSelection.Text.ToString();

            this.Content = new WizardStep3View(sheetView);
        }
    }
}
