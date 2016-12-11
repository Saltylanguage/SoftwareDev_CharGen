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
            if (className == "Bard")
            {
                Class = new Classes.ClassBard();
            }
            if (className == "Cleric")
            {
                Class = new Classes.ClassCleric();
            }
            if (className == "Druid")
            {
                Class = new Classes.ClassDruid();
            }
            if (className == "Fighter")
            {
                Class = new Classes.ClassFighter();
            }
            if (className == "Monk")
            {
                Class = new Classes.ClassMonk();
            }
            if (className == "Paladin")
            {
                Class = new Classes.ClassPaladin();
            }
            if (className == "Ranger")
            {
                Class = new Classes.ClassRanger();
            }
            if (className == "Rogue")
            {
                Class = new Classes.ClassRogue();
            }
            if (className == "Sorcerer")
            {
                Class = new Classes.ClassSorcerer();
            }
            if (className == "Wizard")
            {
                Class = new Classes.ClassWizard();
            }
            else  //in case there is a Class that did not get added to this poorly programmed list of Classes
            {
                Class = new Classes.ClassBarbarian();
            }

        }
    }
}
