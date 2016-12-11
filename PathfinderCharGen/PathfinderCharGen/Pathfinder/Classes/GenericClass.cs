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
        public int classFortSave;
        public int classRefSave;
        public int classWillSave;
      

        public virtual void ClassLevels(uint level)
        {
            Debug.WriteLine("Generic ClassLevels was called");
        }
    }
}
