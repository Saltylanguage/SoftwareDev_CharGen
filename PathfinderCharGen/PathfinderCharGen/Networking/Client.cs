using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.IO;

namespace PathfinderCharGen.Networking
{
    public class Client
    {
        private Client() { }

        private static Client TheInstance;
        public static Client Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new Client();
                }

                return TheInstance;
            }
        }
        public class StateObject
        {
            // Client  socket.  
            public Socket workSocket = null;
            // Size of receive buffer.  
            public const int BufferSize = 1024;
            // Receive buffer.  
            public byte[] buffer = new byte[BufferSize];
            // Received data string.  
            public StringBuilder stringBuilder = new StringBuilder();
        }

        private const int port = 25565;

        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent RecieveDone = new ManualResetEvent(false);

        private static String response = string.Empty;
        public void Initialize(string IP)
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(IP);
                IPEndPoint remoteEndPoint = new IPEndPoint(ipAddress, port);

                //create socket
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.BeginConnect(remoteEndPoint, new AsyncCallback(ConnectCallback), client);
                ConnectDone.WaitOne();


                SendMessage(client, IP.ToString() + "<EOF>");
                SendDone.WaitOne();

                Receive(client);
                RecieveDone.WaitOne();

                Console.WriteLine("Server responded : {0}", response);

                //client.Shutdown(SocketShutdown.Both);
                //client.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                client.EndConnect(ar);

                ConnectDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void Receive(Socket client)
        {
            try
            {
                StateObject state = new StateObject();
                state.workSocket = client;

                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;

                int bytesRead = client.EndReceive(ar);

                //if (bytesRead > 0)
                //{
                //    state.stringBuilder.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                //    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);                    
                //}
                //else
                //{
                state.stringBuilder.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                if (state.stringBuilder.Length > 1)
                {
                    response = state.stringBuilder.ToString();
                }
                RecieveDone.Set();
                //}

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void SendMessage(Socket client, String message)
        {
            byte[] byteMessage = Encoding.ASCII.GetBytes(message);

            client.BeginSend(byteMessage, 0, byteMessage.Length, 0, new AsyncCallback(SendCallback), client);
        }

        private static void SendCallback(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;

                int byteSent = client.EndSend(ar);

                SendDone.Set();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}
