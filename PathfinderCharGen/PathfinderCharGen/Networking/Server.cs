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
    class ConnectedClient
    {
        public Socket handler;
        public string ClientIP;
        public bool IsAlive;
    }

    public class Server
    {
        public Socket SocketListener;
        List<ConnectedClient> RoutingTable = new List<ConnectedClient>();


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
                    //Console.WriteLine("On network thread, waiting for clients");
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


        public void BeginRecievingMessages()
        {
            while (true)
            {
                StateObject state = new StateObject();
                SocketListener.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, new AsyncCallback(SendToRequestManagerCallBack), SocketListener);
            }
        }

        public void SendToRequestManagerCallBack(IAsyncResult ar)
        {
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
                    RequestManager.Instance.PushMessage(state.buffer);
                }
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
                    if (content[0] != '/')
                    {
                        AddClientToRoutingTable(handler, content);
                    }
                    //SendMessage(handler, state.buffer); //send message back to client
                    BroadcastMessage(Encoding.ASCII.GetBytes(RoutingTable.Last().ClientIP));
                    Console.WriteLine("{0}", content);
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

        void AddClientToRoutingTable(Socket handler, string content)
        {
            Console.WriteLine("Adding client to Routing Table");
            ConnectedClient tempClient = new ConnectedClient();
            tempClient.handler = handler;
            tempClient.ClientIP = content.Remove(content.Length - 5, 5);
            tempClient.IsAlive = true;
            //add client to Routing table
            if (RoutingTable.Count == 0)
            {
                RoutingTable.Add(tempClient);
            }
            else
            {
                bool IPfound = false;
                for (int i = 0; i < RoutingTable.Count; ++i) //check list for duplicate IP
                {
                    if (RoutingTable[i].ClientIP == tempClient.ClientIP)
                    {
                        IPfound = true;
                    }
                }
                if (IPfound == false)
                {
                    RoutingTable.Add(tempClient);
                }
            }
        }

        public void BroadcastMessage(byte[] message) //send message to current clients
        {
            if (RoutingTable.Count != 0)
            {
                for (int i = 0; i < RoutingTable.Count; ++i)
                {
                    if (RoutingTable[i].IsAlive == true)
                    {
                        SendMessage(RoutingTable[i].handler, message);
                    }
                }
            }
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        public void UpdateRequests()
        {
            while (true)
            {
                if (!RequestManager.Instance.bIsLocked)
                {
                    if (RequestManager.Instance.mRequests.Count != 0)
                    {
                        RequestManager.Instance.bIsLocked = true;
                        byte[] request = RequestManager.Instance.mRequests.Peek().message;
                        //
                        //byte[] result = parser.read(request);
                        //
                        RequestManager.Instance.PopMessage();
                        RequestManager.Instance.bIsLocked = false;
                        //if(whisper) send to specific player in routing table

                        //else
                        //BroadcastMessage(result);
                    }
                }
            }
        }
    }
}