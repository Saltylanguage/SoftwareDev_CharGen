using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands;

namespace PathfinderCharGen.Networking
{
    public static class MessageProcessing
    {
        public static bool StandardRoutine(NetworkMessage message)
        {
            switch (message.Type)
            {
                case MessageType.None:
                    return false;
                case MessageType.Chat:
                    return ChatRoutine(message);
                case MessageType.Command:
                    return CommandRoutine(message);
                case MessageType.Result:
                    return ResultRoutine(message);
                case MessageType.Notification:
                    return NotificationRoutine(message);
                case MessageType.Whisper:
                    return WhisperRoutine(message);
                default:
                    return false;
            }
        }

        public static bool StandardRoutine(char[] message)
        {
            NetworkMessage nMessage = new NetworkMessage();

            if (ScriptParser.ParseNetworkMessage(message, out nMessage))
            {
                switch (nMessage.Type)
                {
                    case MessageType.None:
                        return false;
                    case MessageType.Chat:
                        return ChatRoutine(nMessage);
                    case MessageType.Command:
                        return CommandRoutine(nMessage);
                    case MessageType.Result:
                        return ResultRoutine(nMessage);
                    case MessageType.Notification:
                        return NotificationRoutine(nMessage);
                    case MessageType.Whisper:
                        return WhisperRoutine(nMessage);
                    default:
                        return false;
                }
            }

            return false;
        }

        public static bool ChatRoutine(NetworkMessage message)
        {
            //format and write chat to chat window
            //looks like:
            //  UserName: SomeText
            //check if player knows the languge otherwise scramble
            return false;
        }

        public static bool CommandRoutine(NetworkMessage message)
        {
            //a command request sent to server
            System.Diagnostics.Debug.Assert(Server.Instance != null, "[MessageProcessing] - CommandRoutine called on client. (Talk to Alex)");

            NetworkMessage result = new NetworkMessage();
            result.Type = MessageType.Result;
            result.Username = message.Username;

            /*
             Some logic to wait for DM permission
            */

            bool control = true;
            if (control == true) //command is allowed 
            {
                DictionaryType type = CommandDictionary.StringToDictionaryType(message.Context);
                Command command = CommandDictionary.Instance.CommandExecute(message.Message, type);

                if (command != null)
                {
                    result.Context = command.result;
                    result.Message = command.ToString();
                }
                else
                {
                    result.Context = "Failed";
                    result.Message = "Command failed";
                }
            }
            else //command is denied
            {
                result.Context = "Denied";
                result.Message = "DM denied your command.";
            }

            return false;
        }

        public static bool ResultRoutine(NetworkMessage message)
        {
            //the result of a command sent from the server
            return false;
        }

        public static bool NotificationRoutine(NetworkMessage message)
        {
            //simular to chat but formated differently
            return false;
        }

        public static bool WhisperRoutine(NetworkMessage message)
        {
            //simular to chat but only seen by player whisper is directed at
            return false;
        }
    }
}
