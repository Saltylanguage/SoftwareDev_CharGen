using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling.Pathfinder.Classes
{
    public class ClassRanger : GenericClass
    {
        public ClassRanger()
        {
            classFortSave = 2;
            classRefSave = 2;
            classWillSave = 0;
        }

        public void SetFortSave(int lvl)
        {
            if (lvl % 2 == 0)
            {
                classFortSave++;
            }
        }
        public void SetRefSave(int lvl)
        {
            if (lvl % 2 == 0)
            {
                classRefSave++;
            }
        }
        public void SetWillSave(int lvl)
        {
            if (lvl % 3 == 0)
            {
                classWillSave++;
            }
        }
    }
}