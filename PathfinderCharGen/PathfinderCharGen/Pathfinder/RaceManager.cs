using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;
using Reactive;

namespace ReactiveLeveling.Races
{
    public class RaceManager
    {
        public Races.GenericRace Race = new Races.GenericRace();

        public void RaceSelector(string raceChoice) //takes user input to choose their race
        {
            if (raceChoice == "Dwarf")
            {
                Race = new Races.RaceDwarf();
            }
            if (raceChoice == "Elf")
            {
                Race = new Races.RaceElf();
            }
            if (raceChoice == "Human")
            {
                new Races.RaceGnome();
            }
            if (raceChoice == "Halfling")
            {
                Race = new Races.RaceHalfling();
            }
        }
    }
}

