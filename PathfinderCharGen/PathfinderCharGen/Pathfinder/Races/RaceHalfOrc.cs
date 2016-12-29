using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ReactiveLeveling.Races
{
    public class RaceHalfOrc : GenericRace
    {
        public RaceHalfOrc() // +2 any
        {

        }

        public override string Size() // medium
        {
            return SizeOfCharacter.medium.ToString();
        }

        public override void PrintRaceName()
        {
            Debug.WriteLine("Half-Orc");
        }
    }
}
