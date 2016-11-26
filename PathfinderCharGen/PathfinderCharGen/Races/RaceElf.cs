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
        public override Tuple<int, int, int, int, int, int> SetRacialStatChanges() // +2 dex, -2 con, +2 itl
        {
            int elfStr = 0, elfDex = 2, elfCon = -2, elfItl = 2, elfWis = 0, elfCha = 0; 
            return new Tuple<int, int, int, int, int, int>(elfStr, elfDex, elfCon, elfItl, elfWis, elfCha);
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
