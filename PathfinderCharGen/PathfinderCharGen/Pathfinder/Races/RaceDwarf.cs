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
        public override Tuple<int, int, int, int, int, int> SetRacialStatChanges() // +2 con, +2 wis, -2 cha
        {
            int dwarfStr = 0, dwarfDex = 0, dwarfCon = 2, dwarfItl = 0, dwarfWis = 2, dwarfCha = -2;
            return new Tuple<int, int, int, int, int, int>(dwarfStr, dwarfDex, dwarfCon, dwarfItl, dwarfWis, dwarfCha);
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
