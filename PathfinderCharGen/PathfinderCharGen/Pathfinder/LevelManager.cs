using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using Reactive.Bindings;

namespace ReactiveLeveling
{
    public class LevelManager
    {
        public int level = 1;
        public int exp = 0;

        public LevelManager()
        {
            level = 0;
            exp = 0;
        }

        public void IncreaseLevel()
        {
            level++;
            Debug.WriteLine("Player Leveled Up\n", level.ToString()); //remove later            
        }

        public void IncreaseExp(int addExp) //way of checking level and exp increase
        {
            int expForNextLevel;
            exp += addExp;
            switch (level)
            {
                case 0:
                    {
                        expForNextLevel = 0;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 1:
                    {
                        expForNextLevel = 1300;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 2:
                    {
                        expForNextLevel = 3300;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 3:
                    {
                        expForNextLevel = 6000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 4:
                    {
                        expForNextLevel = 10000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 5:
                    {
                        expForNextLevel = 15000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 6:
                    {
                        expForNextLevel = 23000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 7:
                    {
                        expForNextLevel = 34000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 8:
                    {
                        expForNextLevel = 50000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 9:
                    {
                        expForNextLevel = 71000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 10:
                    {
                        expForNextLevel = 105000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 11:
                    {
                        expForNextLevel = 145000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 12:
                    {
                        expForNextLevel = 210000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 13:
                    {
                        expForNextLevel = 295000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 14:
                    {
                        expForNextLevel = 425000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 15:
                    {
                        expForNextLevel = 600000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 16:
                    {
                        expForNextLevel = 850000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 17:
                    {
                        expForNextLevel = 1200000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 18:
                    {
                        expForNextLevel = 1700000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }
                case 19:
                    {
                        expForNextLevel = 2400000;
                        CheckExperienceToNextLevel(expForNextLevel);
                        break;
                    }



                default:  //in case it broke
                    {
                        Debug.WriteLine("CheckThis: IncreaseExp switch case hit default case");
                        break;
                    }
            }

        }

        void CheckExperienceToNextLevel(int expForNextLevel)
        {
            if (exp >= expForNextLevel)
            {
                exp -= expForNextLevel;
                IncreaseLevel();
            }
        }
    }
}
