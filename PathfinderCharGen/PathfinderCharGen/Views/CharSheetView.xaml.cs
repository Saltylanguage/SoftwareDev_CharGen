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

        private void MenuItem_Click_Connect(object sender, RoutedEventArgs e)
        {
            Window window = new Window { Content = new PathfinderCharGen.Views.ConnectionWindow(), Height = 320, Width = 300, WindowStartupLocation = WindowStartupLocation.CenterScreen };
            window.ShowDialog();
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
                SelectType();

                CMD_Text.Text = "";
            }
        }

        private void SendClick(object sender, RoutedEventArgs e)
        {
            SelectType();

            CMD_Text.Text = "";
        }

        private void ClearClick(object sender, RoutedEventArgs e)
        {
            ChatTextBox.Clear();
        }

        private void SelectType()
        {
            if (CMD_Text.Text == "")
            {
                return;
            }

            switch (ChatTypeBox.Text)
            {
                case "Chat":
                    TypeChat();
                    break;
                case "Command":
                    TypeCommand();
                    break;
                case "Notification":
                    TypeTestSend();
                    break;
                case "Whisper":
                    TypeTestRecieve();
                    break;
                default:
                    break;
            }
        }

        private void TypeChat()
        {
            ChatTextBox.Text += PlayerName.Text + ": " + CMD_Text.Text + "\n";
        }

        private void TypeCommand()
        {
            Command command = CommandDictionary.Instance.CommandExecute(CMD_Text.Text);
            if (command != null)
            {
                ChatTextBox.Text += PlayerName.Text + ": (" + command.name + ") " + command.ToString() + "\n";
            }
            else
            {
                ChatTextBox.Text += "Invalid Command\n";
            }
        }

        private void TypeTestSend()
        {
            Networking.NetworkMessage testNM = new Networking.NetworkMessage();
            char[] testCA;

            testNM.Type = Networking.NetworkMessage.StringToMessageType(ChatTypeBox.Text);
            testNM.Username = PlayerName.Text;
            testNM.Context = ChatExtraBox.Text;
            testNM.Message = CMD_Text.Text;

            if (Networking.ScriptParser.PrepNetworkMessage(testNM, out testCA))
            {
                string temp = new string(testCA);
                ChatTextBox.Text += temp + "\n";
            }
            else
            {
                ChatTextBox.Text += "error\n";
            }
        }

        private void TypeTestRecieve()
        {
            Networking.NetworkMessage testNM = new Networking.NetworkMessage();
            char[] testCA = CMD_Text.Text.ToCharArray();

            if (Networking.ScriptParser.ParseNetworkMessage(testCA, out testNM))
            {
                ChatTextBox.Text += "---\n";
                ChatTextBox.Text += "Type = " + Networking.NetworkMessage.MessageTypeToString(testNM.Type) + "\n";
                ChatTextBox.Text += "Username = " + testNM.Username + "\n";
                ChatTextBox.Text += "Context = " + testNM.Context + "\n";
                ChatTextBox.Text += "Message = " + testNM.Message + "\n";
                ChatTextBox.Text += "---\n";
            }
            else
            {
                ChatTextBox.Text += "error\n";
            }
        }
    }
}
