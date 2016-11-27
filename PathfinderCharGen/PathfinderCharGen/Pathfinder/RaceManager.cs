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

        public void RaceSelector(uint raceChoice) //takes user input to choose their race
        {
            switch (raceChoice)
            {
                case 0:
                    {
                        Race = new Races.RaceDwarf();
                        break;
                    }
                case 1:
                    {
                        Race = new Races.RaceElf();
                        break;
                    }
                case 2:
                    {
                        Race = new Races.RaceGnome();
                        break;
                    }
                case 3:
                    {
                        Race = new Races.RaceHalfling();
                        break;
                    }
                default: //defaults to dwarf
                    {
                        Race = new Races.RaceDwarf();
                        break;
                    }
            }
        }
    }
}
