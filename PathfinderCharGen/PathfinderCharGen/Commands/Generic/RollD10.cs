﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands.Generic
{
    public class RollD10 : Command
    {
       

        public override void Acquire()
        {
            throw new NotImplementedException();
        }

        public override void Execute()
        {
            Random random = new Random();
            int rand = random.Next(1, 10);

            
            Console.WriteLine("You Rolled a {0}", result);  //TODO make a window popup that displays the result of the dice roll
            result = rand.ToString();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
