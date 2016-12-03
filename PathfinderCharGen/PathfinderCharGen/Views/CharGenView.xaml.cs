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
using PathfinderCharGen.ViewModels;
using PathfinderCharGen.Utilities;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for CharGenView.xaml
    /// </summary>
    public partial class CharGenView : UserControl
    {
        public CharGenView()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            Save.SaveDialog(this);
        }

        private void MenuItem_Click_Load(object sender, RoutedEventArgs e)
        {
            Load.LoadDialog(this);
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            CalcBtn.Command.Execute(this);
        }
    }
}
