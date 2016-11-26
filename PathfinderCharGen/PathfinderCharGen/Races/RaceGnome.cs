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
        public override Tuple<int, int, int, int, int, int> SetRacialStatChanges() // -2 str, +2 con, +2 itl
        {
            int gnomeStr = -2, gnomeDex = 0, gnomeCon = 2, gnomeItl = 0, gnomeWis = 0, gnomeCha = 2;
            return new Tuple<int, int, int, int, int, int>(gnomeStr, gnomeDex, gnomeCon, gnomeItl, gnomeWis, gnomeCha);
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
