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
using System.Windows.Shapes;
using PathfinderCharGen.Networking;

namespace PathfinderCharGen.Views
{
    /// <summary>
    /// Interaction logic for ConnectionWindow.xaml
    /// </summary>
    /// 
    public partial class ConnectionWindow : UserControl
    {
        NetworkingManager networkManager = NetworkingManager.Instance;
        Server server = Server.Instance;
        Client client = Client.Instance;
        public ConnectionWindow()
        {
            InitializeComponent();
        }

        private void Connection_Click(object sender, RoutedEventArgs e)
        {
            client.Initialize(IP_TextBox.Text);
        }

        private void Host_Click(object sender, RoutedEventArgs e)
        {
            networkManager.InitializeServer(IP_TextBox.Text);
        }
    }
}
