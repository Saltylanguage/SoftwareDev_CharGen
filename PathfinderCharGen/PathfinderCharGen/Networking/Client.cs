using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;

namespace PathfinderCharGen.Networking
{
    public class Client
    {
        TcpClient client;
        Stream stream;

        public void Initialize(string IP)
        {
            try
            {
                client = new TcpClient();
                Debug.WriteLine("Connecting...");

                client.Connect(IP, 25565);
                stream = client.GetStream(); //for sending messages to the server          
            }
            catch (Exception e)
            {
                Debug.WriteLine("Client Error " + e.StackTrace);
            }
        }

        public void SendMessage(string message)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] messageBuffer = encoding.GetBytes(message);
            stream.Write(messageBuffer, 0, messageBuffer.Length);
        }

        public void Update()
        {
            if (stream == null)
            {
                return;
            }
            byte[] messageBuffer = new byte[1000];
            int k = stream.Read(messageBuffer, 0, 1000);


            for (int i = 0; i < k; i++) //recieved message
            {
                Debug.Write(Convert.ToChar(messageBuffer[i]));
            }
        }

        public void Terminate()
        {
            client.Close();
        }

    }
}
