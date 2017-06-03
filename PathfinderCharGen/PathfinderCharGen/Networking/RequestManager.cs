using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PathfinderCharGen.Networking
{
    public class RequestManager
    {
        private static RequestManager TheInstance;
        public static RequestManager Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new RequestManager();
                }

                return TheInstance;
            }
        }

        public class QueuedMessage
        {
            public QueuedMessage(byte[] msg)
            {
                message = msg;
            }
            public byte[] message = new byte[1024];
        }

        public Queue<QueuedMessage> mRequests;
        public bool bIsLocked = false;

        public void PushMessage(byte[] message)
        {
            lock (this)
            {
                if (bIsLocked)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch(Exception err)
                    {
                        Debug.WriteLine("Request Manager Error " + err.StackTrace);
                    }

                }
                else
                {
                    bIsLocked = true;
                }
                mRequests.Enqueue(new QueuedMessage(message));
                bIsLocked = false;
                Monitor.Pulse(this);
            }
        }

        public void PopMessage()
        {
            mRequests.Dequeue();
        }
    }
}
