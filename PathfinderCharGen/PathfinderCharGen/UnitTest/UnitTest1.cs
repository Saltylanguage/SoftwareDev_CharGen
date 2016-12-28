using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CharacterClassTest
    {

        public void SetClassAndValues_HappyPath(string className, int fort, int reflex, int will)
        {
            ReactiveLeveling.Pathfinder.Character testChar = new ReactiveLeveling.Pathfinder.Character();

            testChar.SetClassType(className);

            Assert.AreEqual(testChar.statMgr.classMngr.Class.classFortSave, fort, "[ " + className + " test failed] FortSave is not equal to expected value");

            Assert.AreEqual(testChar.statMgr.classMngr.Class.classRefSave, reflex, "[ " + className + " test failed] RefSave is not equal to expected value");

            Assert.AreEqual(testChar.statMgr.classMngr.Class.classWillSave, will, "[ " + className + " test failed] WillSave is not equal to expected value");        

        }

        public void SetInvalidValues_SadPath(int fort, int reflex, int will)
        {
            ReactiveLeveling.Pathfinder.Character testChar = new ReactiveLeveling.Pathfinder.Character();

            testChar.SetClassType("Barbarian");

            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classFortSave, fort, "FortSave SadPath Failed. (Returned expected Values)");

            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classRefSave, reflex, "RefSave SadPath Failed. (Returned expected Values)");

            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classWillSave, will, "WillSave SadPath Failed. (Returned expected Values)");
        }

        public void SetInvalidName_SadPath(string className)
        {
            ReactiveLeveling.Pathfinder.Character testChar = new ReactiveLeveling.Pathfinder.Character();

            testChar.SetClassType(className);
                    
            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classFortSave, 2, "FortSave SadPath Failed. (Returned expected Values)");

            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classRefSave, 1, "RefSave SadPath Failed. (Returned expected Values)");

            Assert.AreNotEqual(testChar.statMgr.classMngr.Class.classWillSave, 1, "WillSave SadPath Failed. (Returned expected Values)");
        }


        [TestMethod]
        public void testAllCharacterClasses_HappyPath()
        {
            SetClassAndValues_HappyPath("Barbarian", 2, 0, 0);
            SetClassAndValues_HappyPath("Bard", 0, 2, 2);
            SetClassAndValues_HappyPath("Cleric", 2, 0, 2);
            SetClassAndValues_HappyPath("Druid", 2, 0, 2);
            SetClassAndValues_HappyPath("Fighter", 2, 0, 0);
            SetClassAndValues_HappyPath("Monk", 2, 2, 2);
            SetClassAndValues_HappyPath("Paladin", 2, 0, 2);
            SetClassAndValues_HappyPath("Ranger", 2, 2, 0);
            SetClassAndValues_HappyPath("Rogue", 0, 2, 0);
            SetClassAndValues_HappyPath("Sorcerer", 0, 0, 2);
            SetClassAndValues_HappyPath("Wizard", 0, 0, 2);
        }

        [TestMethod]
        public void testInvalidClassValues()
        {
            SetInvalidValues_SadPath(1, 1, 1);
        }

        [TestMethod]
        public void testInvalidClassName()
        {
           SetInvalidName_SadPath("Bardbarian");
        }


    }
}
