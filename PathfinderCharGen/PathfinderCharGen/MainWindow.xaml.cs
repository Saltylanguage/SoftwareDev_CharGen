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
using System.Windows.Threading;
using ReactiveLeveling;
using PathfinderCharGen.Commands;
using PathfinderCharGen.Views;
using PathfinderCharGen.ViewModels;
using PathfinderCharGen.Utilities;
using PathfinderCharGen.Networking;
using System.IO;

namespace PathfinderCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharSheetView sheetView = new CharSheetView();
        DispatcherTimer dispatchTimer = new DispatcherTimer();
        public MainWindow()
        {
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            path = System.IO.Path.GetDirectoryName(path) + "\\SaveFiles";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            Save.TheSavePath = path;

            CommandDictionary.Instance.Initialize();

            UpdateLoop.Instance.Initialize();

            InitializeComponent();
            //UpdateLoop.Instance.dispatcherTimer.Tick += new EventHandler(UpdateNetwork);

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
