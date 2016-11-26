using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;

namespace ReactiveLeveling.Classes
{
    class ClassBarbarian : GenericClass
    {
        public override void ClassLevels(uint level)
        {
            switch(level)
            {
                case 1:
                    {
                        classFortSave.Value = 2;
                        classFirstAttackBonus.Value = 1;
                        // Fastmovement movement
                        // Rage
                        break;
                    }
                case 2:
                    {
                        classFortSave.Value = 3;
                        classFirstAttackBonus.Value = 2;
                        // Rage power
                        // Uncanny dodge
                        break;
                    }
                case 3:
                    {
                        classFortSave.Value = 3;
                        classRefSave.Value = 1;
                        classWillSave.Value = 1;
                        classFirstAttackBonus.Value = 3;
                        // Trap Sense + 1
                        break;
                    }
                case 4:
                    {
                        classFortSave.Value = 4;
                        classRefSave.Value = 1;
                        classWillSave.Value = 1;
                        classFirstAttackBonus.Value = 4;
                        // Rage power
                        break;
                    }
                case 5:
                    {
                        classFortSave.Value = 4;
                        classRefSave.Value = 1;
                        classWillSave.Value = 1;
                        classFirstAttackBonus.Value = 5;
                        // Improved uncanny dodge
                        break;
                    }
                case 6:
                    {
                        classFortSave.Value = 5;
                        classRefSave.Value = 2;
                        classWillSave.Value = 2;
                        classFirstAttackBonus.Value = 6;
                        // Rage power
                        // Trap sense + 2
                        break;
                    }
                case 7:
                    {
                        classFortSave.Value = 5;
                        classRefSave.Value = 2;
                        classWillSave.Value = 2;
                        classFirstAttackBonus.Value = 7;
                        // Damage reduction 1/-
                        break;
                    }
                case 8:
                    {
                        classFortSave.Value = 6;
                        classRefSave.Value = 2;
                        classWillSave.Value = 2;
                        classFirstAttackBonus.Value = 8;
                        // Rage power
                        break;
                    }
                case 9:
                    {
                        classFortSave.Value = 6;
                        classRefSave.Value = 3;
                        classWillSave.Value = 3;
                        classFirstAttackBonus.Value = 9;
                        // Trap Sense + 3
                        break;
                    }
                case 10:
                    {
                        classFortSave.Value = 7;
                        classRefSave.Value = 3;
                        classWillSave.Value = 3;
                        classFirstAttackBonus.Value = 10;
                        // Damage Reduction 2/-
                        // Rage power
                        break;
                    }
                case 11:
                    {
                        classFortSave.Value = 7;
                        classRefSave.Value = 3;
                        classWillSave.Value = 3;
                        classFirstAttackBonus.Value = 11;
                        // Greater Rage
                        break;
                    }
                case 12:
                    {
                        classFortSave.Value = 8;
                        classRefSave.Value = 4;
                        classWillSave.Value = 4;
                        classFirstAttackBonus.Value = 12;
                        // Rage power
                        // Trap Sense + 4
                        break;
                    }
                case 13:
                    {
                        classFortSave.Value = 8;
                        classRefSave.Value = 4;
                        classWillSave.Value = 4;
                        classFirstAttackBonus.Value = 13;
                        // Damage Reduction 3/-
                        break;
                    }
                case 14:
                    {
                        classFortSave.Value = 9;
                        classRefSave.Value = 4;
                        classWillSave.Value = 4;
                        classFirstAttackBonus.Value = 14;
                        // Indomitable will
                        // Rage power
                        break;
                    }
                case 15:
                    {
                        classFortSave.Value = 9;
                        classRefSave.Value = 5;
                        classWillSave.Value = 5;
                        classFirstAttackBonus.Value = 15;
                        // Trap Sense + 5
                        break;
                    }
                case 16:
                    {
                        classFortSave.Value = 10;
                        classRefSave.Value = 5;
                        classWillSave.Value = 5;
                        classFirstAttackBonus.Value = 16;
                        // Damage Reduction 4/-
                        // Rage power
                        break;
                    }
                case 17:
                    {
                        classFortSave.Value = 10;
                        classRefSave.Value = 5;
                        classWillSave.Value = 5;
                        classFirstAttackBonus.Value = 17;
                        // Timeless rage
                        break;
                    }
                case 18:
                    {
                        classFortSave.Value = 11;
                        classRefSave.Value = 6;
                        classWillSave.Value = 6;
                        classFirstAttackBonus.Value = 18;
                        // Rage power
                        // TRap Sense + 6
                        break;
                    }
                case 19:
                    {
                        classFortSave.Value = 11;
                        classRefSave.Value = 6;
                        classWillSave.Value = 6;
                        classFirstAttackBonus.Value = 19;
                        // Damage Reduction 5/-
                        break;
                    }
                case 20:
                    {
                        classFortSave.Value = 12;
                        classRefSave.Value = 6;
                        classWillSave.Value = 6;
                        classFirstAttackBonus.Value = 20;
                        // Mighty Rage
                        // Rage power
                        break;
                    }
            }
        }
    }
}
