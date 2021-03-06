﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands;
using PathfinderCharGen.Networking;

namespace PathfinderCharGen.Networking
{
    public static class ScriptParser
    {
        private static char[] delimiter = { ':' };

        public static byte[] byteResult;

        public static bool ParseNetworkMessage(byte[] message, out NetworkMessage result)
        {
            result = new NetworkMessage();

            string temp = System.Text.Encoding.Default.GetString(message);
            string[] split = temp.Split(delimiter, 4);

            switch (split[0])
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
                    result.Type = MessageType.Whisper;
                    break;
                default:
                    return false;
            }

            result.Username = split[1];
            result.Context = split[2];
            result.Message = split[3];

            return true;
        }

        public static bool PrepNetworkMessage(NetworkMessage message, out byte[] result)
        {
            result = new byte[0];

            string final = "";

            switch (message.Type)
            {
                case MessageType.Chat:
                    final += "/t";
                    break;
                case MessageType.Command:
                    final += "/c";
                    break;
                case MessageType.Result:
                    final += "/r";
                    break;
                case MessageType.Notification:
                    final += "/n";
                    break;
                case MessageType.Whisper:
                    final += "/w";
                    break;
                default:
                    return false;
            }

            final += ":" + message.Username;
            final += ":" + message.Context;
            final += ":" + message.Message;

            result = Encoding.ASCII.GetBytes(final);

            return true;
        }

        public static bool PrepNetworkMessage(NetworkMessage message)
        {
            string final = "";

            switch (message.Type)
            {
                case MessageType.Chat:
                    final += "/t";
                    break;
                case MessageType.Command:
                    final += "/c";
                    break;
                case MessageType.Result:
                    final += "/r";
                    break;
                case MessageType.Notification:
                    final += "/n";
                    break;
                case MessageType.Whisper:
                    final += "/w";
                    break;
                default:
                    return false;
            }

            final += ":" + message.Username;
            final += ":" + message.Context;
            final += ":" + message.Message;

            byteResult = Encoding.ASCII.GetBytes(final);

            return true;
        }
    }
}
