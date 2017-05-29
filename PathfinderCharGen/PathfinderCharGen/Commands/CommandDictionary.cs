using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands
{
    public enum DictionaryType
    {
        Unknown,
        Utilities,
        Common,
        Custom
    }

    public class CommandDictionary
    {
        private CommandDictionary() { } 

        private static CommandDictionary TheInstance;
        public static CommandDictionary Instance
        {
            get
            {
                if (TheInstance == null)
                {
                    TheInstance = new CommandDictionary();
                }

                return TheInstance;
            }
        }

        private bool Init = false;

        public Dictionary<string, Command> Utilities;
        public Dictionary<string, Command> Common;
        public Dictionary<string, Command> Custom;

        public void Initialize()
        {
            if (Init) return;

            Utilities = new Dictionary<string, Command>();
            Common = new Dictionary<string, Command>();
            Custom = new Dictionary<string, Command>();

            // Fill Utilities
            Utilities.Add("roll_d10", new Generic.RollD10());
            Utilities.Add("roll_d20", new Generic.RollD20());
            Utilities.Add("attack_roll", new Generic.AttackRoll());

            // Fill Common
            Common.Add("power_attack", new Feats.PowerAttack());

            // Fill Custom

            Init = true;
        }

        public Command FindCommand(string command, DictionaryType type = DictionaryType.Unknown)
        {
            Command result;
            command = ParseStringInput(command);

            switch (type)
            {
                case DictionaryType.Unknown:

                    Utilities.TryGetValue(command, out result);
                    if (result != null) return result;

                    Common.TryGetValue(command, out result);
                    if (result != null) return result;

                    Custom.TryGetValue(command, out result);
                    return result;

                case DictionaryType.Utilities:

                    Utilities.TryGetValue(command, out result);
                    return result;

                case DictionaryType.Common:

                    Common.TryGetValue(command, out result);
                    return result;

                case DictionaryType.Custom:

                    Custom.TryGetValue(command, out result);
                    return result;

                default:
                    return null;
            }

            
        }

        public Command CommandAcquire(string command, DictionaryType type = DictionaryType.Unknown)
        {
            Command acquire = FindCommand(command, type);

            if (acquire == null)
                return null;

            acquire.Acquire();

            return acquire;
        }

        public Command CommandExecute(string command, DictionaryType type = DictionaryType.Unknown)
        {
            Command execute = FindCommand(command, type);

            if (execute == null)
                return null;

            execute.Execute();

            return execute;
        }

        public Command CommandRemove(string command, DictionaryType type = DictionaryType.Unknown)
        {
            Command remove = FindCommand(command, type);

            if (remove == null)
                return null;

            remove.Remove();

            return remove;
        }

        private string ParseStringInput(string input)
        {
            input = input.ToLower();
            input = input.Replace(' ', '_');
            return input;
        }

    public static DictionaryType StringToDictionaryType(string input)
        {
            input = input.ToLower();

            switch (input)
            {
                case "utilities":
                    return DictionaryType.Utilities;
                case "common":
                    return DictionaryType.Common;
                case "custom":
                    return DictionaryType.Custom;
                default:
                    return DictionaryType.Unknown;
            }
        }

        public static string DictionaryTypeToString(DictionaryType input)
        {
            switch (input)
            {
                case DictionaryType.Unknown:
                    return "Unknown";
                case DictionaryType.Utilities:
                    return "Utilities";
                case DictionaryType.Common:
                    return "Common";
                case DictionaryType.Custom:
                    return "Custom";
                default:
                    return "";
            }
        }
    }
}
