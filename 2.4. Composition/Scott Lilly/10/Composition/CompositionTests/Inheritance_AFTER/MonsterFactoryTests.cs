using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composition.Inheritance_AFTER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Inheritance_AFTER.Tests
{
    [TestClass()]
    public class MonsterFactoryTests
    {
        [TestMethod()]
        public void Test_BitingMonster()
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Assert.IsTrue(crocodile is BitingMonster);
        }

        [TestMethod()]
        public void Test_BitingKickingMonster()
        {
            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse is KickingMonster);

            // This test will fail, because we cannot inherit from multiple base classes.
            Assert.IsTrue(horse is BitingMonster);
        }

    }
}