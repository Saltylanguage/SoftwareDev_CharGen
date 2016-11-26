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


namespace PathfinderCharGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character hero = new Character();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MaxHP_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) //TODO figure out how to name this one. (THIS IS HP)
        {

        }

        private void AC_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
