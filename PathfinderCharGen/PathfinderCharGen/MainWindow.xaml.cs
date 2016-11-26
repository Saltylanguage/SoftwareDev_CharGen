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
using Microsoft.Win32;
using Newtonsoft.Json;


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

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            //This doesn't work yet
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json) [recomended]|*.json"; //|Xml file (*.xml)|*.xml
            if (saveFileDialog.ShowDialog() == true)
            {
                string json = JsonConvert.SerializeObject(hero);
                System.IO.File.WriteAllText(saveFileDialog.FileName, json);

                int stop = 0;
            }
        }

        private void MenuItem_Click_Load(object sender, RoutedEventArgs e)
        {
            //This doesn't work yet
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json file (*.json)|*.json";
            if (openFileDialog.ShowDialog() == true)
            {
                string json = System.IO.File.ReadAllText(openFileDialog.FileName);
                hero = JsonConvert.DeserializeObject<Character>(json);

                int stop = 0;
            }
        }
    }
}
