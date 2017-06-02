using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composition.Composition_AFTER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition.Composition_AFTER.Tests
{
    [TestClass()]
    public class MonsterFactoryTests
    {
        [TestMethod()]
        public void Test_BitingMonster()
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);

            Assert.IsTrue(crocodile.CanBite);
            Assert.IsFalse(crocodile.CanKick);
            Assert.IsFalse(crocodile.CanPunch);
            Assert.IsFalse(crocodile.CanSpit);
        }

        [TestMethod()]
        public void Test_BitingKickingMonster()
        {
            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse.CanBite);
            Assert.IsTrue(horse.CanKick);
            Assert.IsFalse(horse.CanPunch);
            Assert.IsFalse(horse.CanSpit);
        }
    }
}