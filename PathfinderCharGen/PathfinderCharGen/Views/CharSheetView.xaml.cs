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
using PathfinderCharGen.Commands;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for CharGenView.xaml
    /// </summary>
    public partial class CharSheetView : UserControl
    {

        private GameViewModel GameVM;

        public CharSheetView()
        {
            InitializeComponent();
            GameVM = new GameViewModel();
        }

        public ReactiveLeveling.Pathfinder.Character character = new ReactiveLeveling.Pathfinder.Character();

        public void setClassTab()
        {
            if (CharacterClass.Text.ToString() == "Barbarian")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.BarbarianTab();
            }
            if (CharacterClass.Text.ToString() == "Bard")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.BardTab();
            }
            if (CharacterClass.Text.ToString() == "Cleric")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.ClericTab();
            }
            if (CharacterClass.Text.ToString() == "Druid")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.DruidTab();
            }
            if (CharacterClass.Text.ToString() == "Fighter")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.FighterTab();
            }
            if (CharacterClass.Text.ToString() == "Monk")
            {
                ClassTab.Content = new PathfinderCharGen.CustomControls.MonkTab();
            }
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

        public void KeyEventDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Command command = CommandDictionary.Instance.CommandExecute(CMD_Text.Text);
                if (command != null)
                {
                    MessageBox.Show(command.ToString());
                }
                else
                {
                    MessageBox.Show($"Invalid Command");
                }

                //if (GameVM.scriptParser.cmd_Dictionary.ContainsKey(CMD_Text.Text)) 
                //{
                //    Commands.Command cmd = GameVM.scriptParser.cmd_Dictionary[CMD_Text.Text];
                //    cmd.Execute();
                //    string printout = "You Rolled a " + cmd.result;
                //    if (CMD_Text.Text == "Attack Roll")
                //    {
                //        printout += " + " + MAB_Total.Text;
                        
                //    }
                //    if(CMD_Text.Text == "Power Attack")
                //    {

                //        printout += " + " + MAB_Total.Text + " - 1";
                //        GameVM.scriptParser.cmd_Dictionary["DamageRoll"].Execute();
                //    }
                //    MessageBox.Show(printout);
                //}
                //else
                //{
                //    MessageBox.Show($"Invalid Command");
                //}

                CMD_Text.Text = "";
            }
        }

    }
}
