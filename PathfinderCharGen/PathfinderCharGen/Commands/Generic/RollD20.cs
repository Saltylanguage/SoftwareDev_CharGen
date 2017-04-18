using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands.Generic
{
    public class RollD20 : Command
    {
        public override void Acquire()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            Random random = new Random();
            int result = random.Next(1, 20);


            Console.WriteLine("You Rolled a {0}", result);  //TODO make a window popup that displays the result of the dice roll

        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
