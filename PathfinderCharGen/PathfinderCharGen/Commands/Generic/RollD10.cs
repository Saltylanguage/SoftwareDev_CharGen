using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands.Generic
{
    public class RollD10 : Command
    {
        public RollD10()
        {
            name = "Roll D10";
        }

        public override void Acquire()
        {
            
        }

        public override void Execute()
        {
            Random random = new Random();
            int rand = random.Next(1, 10);

            
            result = rand.ToString();
            Console.WriteLine("You Rolled a {0}", result);
        }

        public override void Remove()
        {
            
        }

        public override string ToString()
        {
            int temp = System.Convert.ToInt32(result);
            string aaaaaaaaa = "a";
            if (temp == 11 || temp == 8) { aaaaaaaaa += "n"; }
            return "You Rolled " + aaaaaaaaa + " " + result;
        }
    }
}
