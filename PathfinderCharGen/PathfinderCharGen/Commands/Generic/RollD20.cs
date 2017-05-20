﻿using System;
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
            
        }

        public override void Execute()
        {
            Random random = new Random();
            int rand = random.Next(1, 20);

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
            if (temp == 11 || temp == 8 || temp == 18) { aaaaaaaaa += "n"; } 
            return "You Rolled " + aaaaaaaaa + " " + result;
        }
    }
}
