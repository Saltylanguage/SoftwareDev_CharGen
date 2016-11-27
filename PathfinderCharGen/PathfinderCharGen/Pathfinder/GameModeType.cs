using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling
{
    public class GameModeType
    {
        public uint GameMode(uint choice)
        {
            switch(choice)
            {
                case 0: //low fantasy
                    {
                        return 10;
                    }
                case 1: //standard fantasy
                    {
                        return 15;
                    }
                case 2: //high fantasy
                    {
                        return 20;
                    }
                case 3: //epic fantasy
                    {
                        return 25;
                    }
                default: // defaults to low fantasy
                    {
                        return 10;
                    }
            }
        }

    }
}
