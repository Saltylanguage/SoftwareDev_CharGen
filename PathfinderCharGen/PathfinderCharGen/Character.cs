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

namespace ReactiveLeveling
{
    public class Character
    {
        public StatManager statMgr = new StatManager();

        public void LevelUp() // test version
        {
            statMgr.lvlMgr.IncreaseLevel();
        }

        public void ExpGain() // test version
        {
            statMgr.lvlMgr.IncreaseExp(1000);
        }
        public void PrintInfo()
        {
            Console.WriteLine("-------------Stats-------------");
            Console.WriteLine("Strength: {0}\nRoll Modifier:{1}\n", statMgr.str, statMgr.StrMod);
            Console.WriteLine("Dexterity: {0}\nRoll Modifier:{1}\n", statMgr.dex, statMgr.DexMod);
            Console.WriteLine("Constitution: {0}\nRoll Modifier:{1}\n", statMgr.con, statMgr.ConMod);
            Console.WriteLine("Intellect: {0}\nRoll Modifier:{1}\n", statMgr.itl, statMgr.ItlMod);
            Console.WriteLine("Wisdom: {0}\nRoll Modifier:{1}\n", statMgr.wis, statMgr.WisMod);
            Console.WriteLine("Charisma: {0}\nRoll Modifier:{1}\n", statMgr.cha, statMgr.ChaMod);
            Console.WriteLine("-------------------------------\n");

        }
        public void ChooseRace(uint choice) // test version
        {
            statMgr.SetRaceChoice(choice);
        }

        public void SetGameModeType(uint choice)
        {
            statMgr.SetGameModeType(choice);
        }

        /*
         * 
         * 
        This section will take place after the character has completed their initial stat allocation and confirmed the stats
        *
        * 
        */
        public void IncreaseStat()
        {
            //TODO
        }

        public void DecreaseStat() //this should only be able to decrease stats to their base level which is after they allocate their initial points and added the class and race shit
        {
            //TODO
        }
    }


}

