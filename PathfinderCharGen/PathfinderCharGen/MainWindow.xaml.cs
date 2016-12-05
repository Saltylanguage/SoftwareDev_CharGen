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
using ReactiveLeveling;
using PathfinderCharGen.Commands;
using PathfinderCharGen.Views;
using PathfinderCharGen.ViewModels;
using PathfinderCharGen.Utilities;




namespace PathfinderCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character hero = new Character();
        CharSheetView sheetView = new CharSheetView();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NewCharacterWizard_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Window { Content = new PathfinderCharGen.Views.WizardStep1View(sheetView), Height = 600, Width = 1200, WindowStartupLocation = WindowStartupLocation.CenterScreen };
            this.Close();
            window.ShowDialog();      
        }

        private void LoadCharacterSheet_Click(object sender, RoutedEventArgs e)
        {            
            Load.LoadDialog(sheetView);
            this.Content = sheetView; 
        }
    }
}
