using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Networking
{
    public enum MessageType
    {
        None,
        Chat,
        Command,
        Result,
        Notification,
        Whisper
    }

    public class NetworkMessage
    {
        public MessageType Type;
        public string Username;
        public string Context;
        public string Message;

        public NetworkMessage()
        {
            Type = MessageType.None;
            Username = "";
            Context = "";
            Message = "";
        }


    }
}
