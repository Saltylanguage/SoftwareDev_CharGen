using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        public static MessageType StringToMessageType(string input)
        {
            //Thread thread = new Thread(() => MessageTypeToString(MessageType.Chat));
            //thread.Start();

            input = input.ToLower();

            switch (input)
            {
                case "chat":
                    return MessageType.Chat;
                case "command":
                    return MessageType.Command;
                case "result":
                    return MessageType.Result;
                case "notification":
                    return MessageType.Notification;
                case "whisper":
                    return MessageType.Whisper;
                default:
                    return MessageType.None;
            }
        }

        public static string MessageTypeToString(MessageType input)
        {
            switch (input)
            {
                case MessageType.None:
                    return "None";
                case MessageType.Chat:
                    return "Chat";
                case MessageType.Command:
                    return "Command";
                case MessageType.Result:
                    return "Result";
                case MessageType.Notification:
                    return "Notification";
                case MessageType.Whisper:
                    return "Whisper";
                default:
                    return "";
            }
        }
    }
}
