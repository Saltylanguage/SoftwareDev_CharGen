using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReactiveLeveling.Races
{
    public class RaceDwarf : GenericRace
    {
        public RaceDwarf() // +2 con, +2 wis, -2 cha
        {
            RaceCon = 2;
            RaceWis = 2;
            RaceCha = -2;
        }

        public override string Size() // medium
        {
            return SizeOfCharacter.medium.ToString();
        }

        public override void PrintRaceName()
        {
            Debug.WriteLine("Dwarf");
        }
    }
}
