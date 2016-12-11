using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReactiveLeveling.Races
{
    public class RaceElf : GenericRace
    {
        public RaceElf() // +2 dex, -2 con, +2 itl
        {
            RaceDex = 2;
            RaceCon = -2;
            RaceItl = 2;
        }

        public override string Size() // medium
        {
            return SizeOfCharacter.medium.ToString();
        }

        public override void PrintRaceName()
        {
            Debug.WriteLine("Elf");
        }
    }
}
