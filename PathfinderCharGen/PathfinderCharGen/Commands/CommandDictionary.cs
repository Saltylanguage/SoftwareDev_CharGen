using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands
{
    class CommandDictionary
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
            Utilities.Add("Roll D10", new Generic.RollD10());
            Utilities.Add("Roll D20", new Generic.RollD20());
            Utilities.Add("Attack Roll", new Generic.AttackRoll());

            // Fill Common
            Common.Add("Power Attack", new Feats.PowerAttack());

            // Fill Custom

            Init = true;
        }

        public Command FindCommand(string command)
        {
            Command result;

            Utilities.TryGetValue(command, out result);
            if (result != null) return result;

            Common.TryGetValue(command, out result);
            if (result != null) return result;

            Custom.TryGetValue(command, out result);
            return result;
        }

        public Command CommandAcquire(string command)
        {
            Command acquire = FindCommand(command);

            if (acquire == null)
                return null;

            acquire.Acquire();

            return acquire;
        }

        public Command CommandExecute(string command)
        {
            Command execute = FindCommand(command);

            if (execute == null)
                return null;

            execute.Execute();

            return execute;
        }

        public Command CommandRemove(string command)
        {
            Command remove = FindCommand(command);

            if (remove == null)
                return null;

            remove.Remove();

            return remove;
        }
    }
}
