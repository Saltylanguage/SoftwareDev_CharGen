using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;
using System.Diagnostics;

namespace ReactiveLeveling.Pathfinder.Classes
{
    public class GenericClass
    {
        public int classFortSave = 0;
        public int classRefSave = 0;
        public int classWillSave = 0;

        public virtual void ClassLevels(uint level)
        {
            Debug.WriteLine("Generic ClassLevels was called");
        }
    }
}
