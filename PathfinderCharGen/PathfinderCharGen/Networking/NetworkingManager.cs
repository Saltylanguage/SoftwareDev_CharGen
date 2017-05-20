using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Sockets;

namespace PathfinderCharGen.Networking
{
    class NetworkingManager
    {
        Server server = Server.Instance;


        private static NetworkingManager TheInstance;
        public static NetworkingManager Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new NetworkingManager();
                }

                return TheInstance;
            }
        }

        public void InitializeServer(string IP)
        {
            server.IP = IP;
            Thread NetworkThread = new Thread(new ThreadStart(server.Initialize));
            NetworkThread.Start();
        }

        public void SendServerMessage(string message)
        {
            Server.StateObject state = new Server.StateObject();
            Socket handler  = state.workSocket;
            server.SendMessage(handler, message);
        }


    }
}
