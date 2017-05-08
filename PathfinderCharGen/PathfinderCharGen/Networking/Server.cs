using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace PathfinderCharGen.Networking
{
    public class Server
    {
        public List<Socket> ClientIPList; //list of connected clients
        int ClientSize; //number of connected clients 
        TcpListener TcpListener;

        private Server() { }

        private static Server TheInstance;
        public static Server Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new Server();
                }

                return TheInstance;
            }
        }

        public void Initialize(string IP)
        {
            try
            {
                IPAddress ipAd = IPAddress.Parse(IP);
                TcpListener = new TcpListener(ipAd, 25565);
                TcpListener.Start();

            }
            catch (Exception err)
            {
                Debug.WriteLine("Server Error " + err.StackTrace);
            }
        }
        public void Update()
        {
            if(TcpListener == null)
            {
                return;
            }
            Socket socket = TcpListener.AcceptSocket();
            

            if (!ClientIPList.Contains(socket)) //if you disconnect there may be bad times (currently not removing IPAddress on disconnect)
            {
                ClientIPList.Add(socket);
                ClientSize++;
            }
            Debug.WriteLine("Connection accepted from " + socket.RemoteEndPoint);

            byte[] messageBuffer = new byte[1000];
            int bufferSize = socket.Receive(messageBuffer);
            Debug.WriteLine("Recieved...");

            for (int i = 0; i < bufferSize; ++i) //recieved message
            {
                Debug.Write(Convert.ToChar(messageBuffer[i]));
            }
            SendMessage(messageBuffer); //Send message from Server To Clients
        }

        private void SendMessage(byte[] messageBuffer)
        {
            for (int i = 0; i < ClientSize; i++)
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                ClientIPList[i].Send(messageBuffer);
            }
        }

        public void Terminate() //Shutdown Server
        {
            //socket.Close();
            TcpListener.Stop();
        }

    }
}