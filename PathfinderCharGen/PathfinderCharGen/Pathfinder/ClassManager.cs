using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling.Pathfinder
{
    public class ClassManager
    {
        public Classes.GenericClass Class = new Classes.GenericClass();
        public void SetClass(string className)
        {
            if (className == "Barbarian")
            {
                Class = new Classes.ClassBarbarian();
            }
            else if (className == "Bard")
            {
                Class = new Classes.ClassBard();
            }
            else if (className == "Cleric")
            {
                Class = new Classes.ClassCleric();
            }
            else if (className == "Druid")
            {
                Class = new Classes.ClassDruid();
            }
            else if (className == "Fighter")
            {
                Class = new Classes.ClassFighter();
            }
            else if (className == "Monk")
            {
                Class = new Classes.ClassMonk();
            }
            else if (className == "Paladin")
            {
                Class = new Classes.ClassPaladin();
            }
            else if (className == "Ranger")
            {
                Class = new Classes.ClassRanger();
            }
            else if (className == "Rogue")
            {
                Class = new Classes.ClassRogue();
            }
            else if (className == "Sorcerer")
            {
                Class = new Classes.ClassSorcerer();
            }
            else if (className == "Wizard")
            {
                Class = new Classes.ClassWizard();
            }


        }
    }
}
