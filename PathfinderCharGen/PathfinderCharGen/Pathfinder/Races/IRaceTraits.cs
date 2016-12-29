using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling.Races
{
    public enum SizeOfCharacter
    {
        large,
        medium,
        small
    }
    public interface IRaceTraits
    {
        string Size();
    }

}
