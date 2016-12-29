using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReactiveLeveling.Races
{
    public class RaceGnome : GenericRace
    {
        public RaceGnome() // -2 str, +2 con, +2 itl
        {
            RaceStr = -2;
            RaceCon = 2;
            RaceItl = 2;
        }

        public override string Size() // small
        {
            return SizeOfCharacter.small.ToString();
        }

        public override void PrintRaceName()
        {
            Debug.WriteLine("Gnome");
        }
    }
}
