using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharGen.Commands
{
    public abstract class Command
    {
        public string name;
        public string result;
        public abstract void Acquire();
        public abstract void Execute();
        public abstract void Remove();
    }
}
