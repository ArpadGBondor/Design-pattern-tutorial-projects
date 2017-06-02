using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjection.NonPatternVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.NonPatternVersion.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        // Test that we recieve an exception, if the name parameter is an empty string.
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName()
        {
            Player player = Player.CreateNewPlayer("");
        }

        // Other tests would require a running database, which might have problems.
    }
}