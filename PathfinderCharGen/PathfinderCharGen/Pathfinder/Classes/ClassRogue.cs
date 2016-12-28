﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling.Pathfinder.Classes
{
    public class ClassRogue : GenericClass
    {
        public ClassRogue()
        {
            classFortSave = 0;
            classRefSave = 2;
            classWillSave = 0;
            skillPoints = 8;
        }

        public void SetFortSave(int lvl)
        {
            if (lvl % 3 == 0)
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

        public void SetSkillPoints()
        {
            skillPoints += 8;
        }
    }
}