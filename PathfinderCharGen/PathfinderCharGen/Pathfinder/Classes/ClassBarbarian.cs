using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;
using ReactiveLeveling.Pathfinder.Classes;

namespace ReactiveLeveling.Pathfinder.Classes
{
    public class ClassBarbarian : GenericClass
    {
        public ClassBarbarian()
        {
            classFortSave = 2;
            classRefSave = 0;
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
            if (lvl % 3 == 0)
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
