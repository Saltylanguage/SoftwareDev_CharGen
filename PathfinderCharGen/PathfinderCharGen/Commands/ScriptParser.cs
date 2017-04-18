using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands.Generic;


namespace PathfinderCharGen.Commands
{
    public class ScriptParser
    {
        public ScriptParser()
        {
            cmd_Dictionary = new Dictionary<string, Command>();

            cmd_Dictionary.Add("Roll D10", new RollD10());
            cmd_Dictionary.Add("Roll D20", new RollD20());
        }

        public Dictionary<string, Command> cmd_Dictionary;



    }
}
