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

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for CharGenView.xaml
    /// </summary>
    public partial class CharSheetView : UserControl
    {
        public ReactiveLeveling.Pathfinder.Character character= new ReactiveLeveling.Pathfinder.Character();
     
        public CharSheetView()
        {
            InitializeComponent();
        }

        public CharSheetView(CharSheetView SV)
        {            
            this.Content = SV.Content;
            InitializeComponent();                
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            Save.SaveDialog(this);
        }

        private void MenuItem_Click_Load(object sender, RoutedEventArgs e)
        {
            Load.LoadDialog(this);
            CalcBtn.Command.Execute(this);
        }

        private void TextBoxLostFocus(object sender, RoutedEventArgs e)
        {
            CalcBtn.Command.Execute(this);
        }

        private void MenuItem_Click_Import(object sender, RoutedEventArgs e)
        {
            Load.LoadPic(this);                            
        }

        private void Acrobatics_Rank_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcBtn.Command.Execute(this);
        }
    }
}
