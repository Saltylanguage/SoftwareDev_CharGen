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
    public class StatManager
    {
        public LevelManager lvlMgr = new LevelManager();
        public Races.RaceManager raceMgr = new Races.RaceManager();
        public ClassManager classMngr = new ClassManager();

        public uint str, dex, con, itl, wis, cha; //main stats that will be changed and updated
        public int StrMod, ConMod, DexMod, ItlMod, WisMod, ChaMod; //main Ability roll modifier
        

        public void AbilityRollModUpdate() // the Ability Modifier equation for all of the stats for the seperate set of variables
        {
            StrMod = AbilityRollEquation((int)str);
            DexMod = AbilityRollEquation((int)dex);
            ConMod = AbilityRollEquation((int)con);
            ItlMod = AbilityRollEquation((int)itl);
            WisMod = AbilityRollEquation((int)wis);
            ChaMod = AbilityRollEquation((int)cha);
        }

        int AbilityRollEquation(int stat)
        {
            if (stat >= 10)
            {
                return (stat - 10) / 2;
            }
            else return 0;
        }

        public void SetRaceChoice(string raceName)
        {
            raceMgr.RaceSelector(raceName);
        }

        public void SetClassChoice(string className)
        {
            classMngr.SetClass(className);
        }


        

    }
}


