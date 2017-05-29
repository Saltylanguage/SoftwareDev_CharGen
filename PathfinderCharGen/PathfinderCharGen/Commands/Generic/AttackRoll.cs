using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PathfinderCharGen.ViewModels;

namespace PathfinderCharGen.Commands.Generic
{
    class AttackRoll : Command
    {
        public AttackRoll()
        {
            name = "Attack Roll";
        }

        public override void Acquire()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            Random random = new Random();
            int rand = random.Next(1, 20);
           
            Console.WriteLine("You Rolled a {0}", result);
            result = rand.ToString();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }


    }
}
