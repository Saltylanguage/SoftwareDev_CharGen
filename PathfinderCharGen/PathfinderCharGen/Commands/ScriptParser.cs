using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.Commands;


namespace PathfinderCharGen.Commands
{
    public class ScriptParser
    {
        public ScriptParser()
        {
            cmd_Dictionary = new Dictionary<string, Command>();

            cmd_Dictionary.Add("Roll D10", new Generic.RollD10());
            cmd_Dictionary.Add("Roll D20", new Generic.RollD20());
            cmd_Dictionary.Add("Attack Roll", new Generic.AttackRoll());
            cmd_Dictionary.Add("Power Attack", new Feats.PowerAttack());
        }

        public Dictionary<string, Command> cmd_Dictionary;



    }
}
