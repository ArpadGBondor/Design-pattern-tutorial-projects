using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypePattern.PatternVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.PatternVersion.Tests
{
    [TestClass()]
    public class Test_Prototype
    {
        [TestMethod()]
        public void Test_PrototypePattern()
        {
            Monster standardGientSpider = new Monster("Giant Spider", 10);

            Monster spider2 = standardGientSpider.Clone();

            Assert.AreEqual(10, standardGientSpider.HitPoints);
            Assert.AreEqual(10, spider2.HitPoints);

            spider2.ApplyDamage(2);

            // There is no reference problem,
            // because we created spider2 by calling the Monster constructor.
            Assert.AreEqual(10, standardGientSpider.HitPoints);
            Assert.AreEqual(8, spider2.HitPoints);
        }
    }
}