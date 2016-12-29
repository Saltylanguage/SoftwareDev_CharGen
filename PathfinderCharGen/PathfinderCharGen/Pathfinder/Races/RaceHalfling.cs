using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReactiveLeveling.Races
{
    public class RaceHalfling : GenericRace
    {
        public RaceHalfling() // -2 str, +2 dex, +2 cha
        {
            RaceStr = -2;
            RaceDex = 2;
            RaceCha = 2;
        }

        public override string Size() // small
        {
            return SizeOfCharacter.small.ToString();
        }

        public override void PrintRaceName()
        {
            Debug.WriteLine("Halfling");
        }
    }
}
