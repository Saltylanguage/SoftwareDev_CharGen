using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Threading;


namespace PathfinderCharGen.Networking
{
    public class Server
    {
        Socket SocketListener;
        public string IP { get; set; }
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

        //Thread reset
        private ManualResetEvent allDone = new ManualResetEvent(false);

        public void Initialize()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse(IP);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 25565);
                SocketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                SocketListener.Bind(localEndPoint);
                SocketListener.Listen(100);

                while (true)
                {
                    Console.WriteLine("On network thread, waiting for cleints");
                    allDone.Reset();
                    SocketListener.BeginAccept(new AsyncCallback(AcceptCallback), SocketListener);
                    //allDone.WaitOne();
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine("Server Error " + err.StackTrace);
            }
        }

        private void AcceptCallback(IAsyncResult ar)
        {
            Console.WriteLine("AcceptCallback called");
            //creates a new handler socket for handling each client that connects
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);
            allDone.Set(); //tell thread to continue

            Console.WriteLine("Client accepted");

            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReadCallback), state);
        }

        private void ReadCallback(IAsyncResult ar)
        {
            Console.WriteLine("ReadCallback called");
            string content = string.Empty;
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                state.stringBuilder.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));

                content = state.stringBuilder.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {

                    //Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                    //    content.Length, content);

                    SendMessage(handler, content); //send message back to client 
                    Console.WriteLine("Responded to Client");
                }
                else
                {
                    // Not all data received. Get more.  
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        public void SendMessage(Socket handler, string message)
        {
            byte[] byteMessage = Encoding.ASCII.GetBytes(message);

            handler.BeginSend(byteMessage, 0, byteMessage.Length, 0, new AsyncCallback(SendCallback), handler);
        }
        public void SendMessage(Socket handler, byte[] message)
        {
            handler.BeginSend(message, 0, message.Length, 0, new AsyncCallback(SendCallback), handler);
        }

        private void SendCallback(IAsyncResult ar)
        {
            Console.WriteLine("SendCallback called");
            try
            {
                Socket handler = (Socket)ar.AsyncState;

                int byteSent = handler.EndSend(ar);

                //handler.Shutdown(SocketShutdown.Both);
                //handler.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}