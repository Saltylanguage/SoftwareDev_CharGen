using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;

namespace ReactiveLeveling.Races
{
    public class GenericRace : IRaceTraits
    {

        public ReactiveProperty<uint> FreeStatPoints = new ReactiveProperty<uint>(0); //this will change to 2 for classes that do not have preset Racial stats

        public virtual Tuple<int, int, int, int, int, int> SetRacialStatChanges() //should never be called
        {
            Debug.WriteLine("The Generic Race SetRacialStatChanges was called.");
            return new Tuple<int, int, int, int, int, int>(0,0,0,0,0,0);
        }

        public virtual string Size() //should never be called
        {
            string err = "Error";
            Debug.WriteLine("The Generic Race Size was called");
            return err;
        }

        public virtual void PrintRaceName() //should never be called
        {
            Debug.WriteLine("Print Generic Race was called");
        }        
    }
}
