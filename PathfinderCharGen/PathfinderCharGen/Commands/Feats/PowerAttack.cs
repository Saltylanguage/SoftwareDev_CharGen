using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands.Feats
{
    class PowerAttack : Command
    {
        public PowerAttack()
        {
            name = "Power Attack";
        }

        public override void Acquire()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            Random random = new Random();
            int rand = random.Next(1, 20);

            

            Console.WriteLine("You Rolled a {0}", result);  //TODO make a window popup that displays the result of the dice roll
            result = rand.ToString();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
