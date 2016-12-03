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
    public class StatManager
    {
        public LevelManager lvlMgr = new LevelManager();
        public Races.RaceManager raceMgr = new Races.RaceManager();
        public GameModeType gameMode = new GameModeType();

        public uint str, dex, con, itl, wis, cha; //main stats that will be changed and updated
        public int StrMod, ConMod, DexMod, ItlMod, WisMod, ChaMod; //main Ability roll modifier
        public uint levelingStatPoints = 0; //for use after player has confirmed they are finished character creation


        public ReactiveProperty<uint> Strength = new ReactiveProperty<uint>(19);
        public ReactiveProperty<uint> Dexerity = new ReactiveProperty<uint>(10);
        public ReactiveProperty<uint> Constitution = new ReactiveProperty<uint>(10);
        public ReactiveProperty<uint> Intellect = new ReactiveProperty<uint>(10);
        public ReactiveProperty<uint> Wisdom = new ReactiveProperty<uint>(10);
        public ReactiveProperty<uint> Charisma = new ReactiveProperty<uint>(10);

        public StatManager()
        {

            IObservable<uint> levelUpObservable = lvlMgr.level; // setting up an oservable sequence of the reactive property 'level' from LevelManager

            IDisposable levelUpDisposible = levelUpObservable.Subscribe(x => StatModifier(x)); // subscribes statModifier, to be called each time level changes and passes in level as the argument as (x)

            if(raceMgr.Race.FreeStatPoints.Value != 0) //for classes that have free Stats
            {
                levelingStatPoints += raceMgr.Race.FreeStatPoints.Value;
            }
        }

        public void SetStatsFromExternalInput(uint ExternStrength, uint ExternDexetrity, uint ExternConstitution, uint ExternIntellect, uint ExternWisdom, uint ExternCharisma) // this is a test function used for execute update
        {
            Strength.Value = ExternStrength;
            Dexerity.Value = ExternDexetrity;
            Constitution.Value = ExternConstitution;
            Intellect.Value = ExternIntellect;
            Wisdom.Value = ExternWisdom;
            Charisma.Value = ExternCharisma;
        }

        void StatModifier(uint newLevel) // subscribes to call OnStatUpdate, and this method is called when level changes
        {
            Debug.WriteLine("******StatModifier was called******"); // remove later
            // this creates an observable sequence that contains multiple sequences that are tupled together as a singular sequence to be called if any one changes
            IObservable<Tuple<uint, uint, uint, uint, uint, uint, uint>> statObservable =
            lvlMgr.level.CombineLatest(Strength, Dexerity, Constitution, Intellect, Wisdom, Charisma, (lvl, str, dex, con, itl, wis, cha)
                => new Tuple<uint, uint, uint, uint, uint, uint, uint>(lvl, str, dex, con, itl, wis, cha));

            IDisposable statDisposible = statObservable.Subscribe(tuple => OnStatUpdate(tuple)); // makes the subscription disposable since it will try to resubscribe everytime it is called
            statDisposible.Dispose();                                                            // which will lead to hanging listeners, that will run through the same sequence multiple times wasteing resources
        }
        public void OnStatUpdate(Tuple<uint, uint, uint, uint, uint, uint, uint> tuple) // gets called when a stat changes, this is part of the statObservable subscription
        {
            Debug.WriteLine("******OnStatUpdate was called******"); // remove later
            //Strength.Value = tuple.Item2;         // Doing this will cause an infinite loop since it triggers itself
            str = tuple.Item2;
            dex = tuple.Item3;
            con = tuple.Item4;
            itl = tuple.Item5;
            wis = tuple.Item6;
            cha = tuple.Item7;
            AbilityRollModUpdate();
        }

        public void AbilityRollModUpdate() // the Ability Modifier equation for all of the stats for the seperate set of variables
        {
            StrMod = AbilityRollEquation((int)str);
            DexMod = AbilityRollEquation((int)dex);
            ConMod = AbilityRollEquation((int)con);
            ItlMod = AbilityRollEquation((int)itl);
            WisMod = AbilityRollEquation((int)wis);
            ChaMod = AbilityRollEquation((int)cha);
        }

        int AbilityRollEquation(int stat)
        {
            if (stat >= 10)
            {
                return (stat - 10) / 2;
            }
            else if (stat < 10)
            {
                switch (stat)
                {
                    case 9:
                        {
                            return -1;
                        }
                    case 8:
                        {
                            return -2;
                        }
                    case 7:
                        {
                            return -4;
                        }
                    default:
                        {
                            return 0;
                        }
                }
            }
            else
            {
                return 0;
            }
        }

        public void SetRaceChoice(uint choice)
        {
            raceMgr.RaceSelector(choice);
        }

        public void SetGameModeType(uint choice)
        {
            gameMode.GameMode(choice);
        }

        

    }
}


