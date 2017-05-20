using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands;
using PathfinderCharGen.Networking;

namespace PathfinderCharGen.Commands
{
    public static class ScriptParser
    {
        public static bool ParseNetworkMessage(char[] message, out NetworkMessage result)
        {
            result = new NetworkMessage();

            string temp = message[0].ToString() + message[1].ToString();

            switch (temp)
            {
                case "/t":
                    result.Type = MessageType.Chat;
                    break;
                case "/c":
                    result.Type = MessageType.Command;
                    break;
                case "/r":
                    result.Type = MessageType.Result;
                    break;
                case "/n":
                    result.Type = MessageType.Notification;
                    break;
                case "/w":
                    result.Type = MessageType.Wisper;
                    break;
                default:
                    return false;
            }

            return true;
        }
    }
}
