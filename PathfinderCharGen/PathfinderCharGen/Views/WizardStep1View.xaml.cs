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
using PathfinderCharGen.Utilities;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for CharGenView.xaml
    /// </summary>
    public partial class WizardStep1View : UserControl
    {

        CharSheetView sheetView;

        public WizardStep1View()
        {                        
            InitializeComponent();
        }

        public WizardStep1View(CharSheetView SV)
        {
            sheetView = SV;
            InitializeComponent();
        }

        private void Step1Next_Click(object sender, RoutedEventArgs e)
        {

            sheetView.PlayerName.Text = playerName.Text.ToString();
            sheetView.CharacterName.Text = CharName.Text.ToString();

            
            this.Content = new WizardStep2View(sheetView);
            
            //this.Content = sheetView;
            //this.Content = new CharSheetView(sheetView);            
        }
    }
}
