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

namespace ReactiveLeveling.Pathfinder
{
    public class Character
    {
        public StatManager statMgr = new StatManager();

        public void ChooseRace(string raceName)
        {
            statMgr.SetRaceChoice(raceName);
        }

        public void SetClassType(string className)
        {
            statMgr.SetClassChoice(className);
        }
    }


}

