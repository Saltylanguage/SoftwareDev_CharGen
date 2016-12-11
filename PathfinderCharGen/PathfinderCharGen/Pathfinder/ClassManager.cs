using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveLeveling.Pathfinder
{
    public class ClassManager
    {
        public void SetClass(string className)
        {
            if (className == "Barbarian")
            {
                Classes.ClassBarbarian barbarian = new Classes.ClassBarbarian();
            }
            if (className == "Bard")
            {
                Classes.ClassBard bard = new Classes.ClassBard();
            }
            if (className == "Cleric")
            {
                Classes.ClassCleric cleric = new Classes.ClassCleric();
            }
            if (className == "Druid")
            {
                Classes.ClassDruid Druid = new Classes.ClassDruid();
            }
            if (className == "Fighter")
            {
                Classes.ClassFighter Fighter = new Classes.ClassFighter();
            }
            if (className == "Monk")
            {
                Classes.ClassMonk Monk = new Classes.ClassMonk();
            }
            if (className == "Paladin")
            {
                Classes.ClassPaladin Paladin = new Classes.ClassPaladin();
            }
            if (className == "Ranger")
            {
                Classes.ClassRanger Ranger = new Classes.ClassRanger();
            }
            if (className == "Rogue")
            {
                Classes.ClassRogue Rogue = new Classes.ClassRogue();
            }
            if (className == "Sorcerer")
            {
                Classes.ClassSorcerer Sorcerer = new Classes.ClassSorcerer();
            }
            if (className == "Wizard")
            {
                Classes.ClassWizard Wizard = new Classes.ClassWizard();
            }
            else  //in case there is a Class that did not get added to this poorly programmed list of Classes
            {
                Classes.ClassBarbarian barbarian = new Classes.ClassBarbarian();
            }

        }
    }
}
