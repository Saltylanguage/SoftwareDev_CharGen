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
        public override Tuple<int, int, int, int, int, int> SetRacialStatChanges() // -2str, +2 dex, +2 cha
        {
            int halflingStr = -2, halflingDex = 2, halflingCon = 2, halflingItl = 0, halflingWis = 0, halflingCha = 2;
            return new Tuple<int, int, int, int, int, int>(halflingStr, halflingDex, halflingCon, halflingItl, halflingWis, halflingCha);
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
