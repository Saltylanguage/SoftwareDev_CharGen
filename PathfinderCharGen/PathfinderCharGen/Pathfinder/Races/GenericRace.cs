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
        public int RaceStr = 0;
        public int RaceDex = 0;
        public int RaceCon = 0;
        public int RaceItl = 0;
        public int RaceWis = 0;
        public int RaceCha = 0;

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
