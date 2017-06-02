using Microsoft.VisualStudio.TestTools.UnitTesting;
using DependencyInjection.PatternVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.PatternVersion.Tests
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

        // Test that we recieve an exception, if the name parameter is an empty string.
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_EmptyName_MockedDataMapper()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            Player player = Player.CreateNewPlayer("",mockPlayerDataMapper);
        }

        // Should receive an exception, because we set the mock PlayerDataMapper
        // to say the playername already exists in the database.
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_CreateNewPlayer_AlreadyExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = true;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);
        }
        // Should succeed, because we set the mock PlayerDataMapper
        // to say the player name does not already exists in the database.
        // Also, when it calls the mock InsertNewPlayerIntoDatabase,
        // the mock mapper will not need a database running.
        [TestMethod()]
        public void Test_CreateNewPlayer_DoesNotAlreadyExistInDatabase()
        {
            MockPlayerDataMapper mockPlayerDataMapper = new MockPlayerDataMapper();

            mockPlayerDataMapper.ResultToReturn = false;

            Player player = Player.CreateNewPlayer("Test", mockPlayerDataMapper);

            Assert.AreEqual("Test", player.Name);
            Assert.AreEqual(0, player.ExperiencePoints);
            Assert.AreEqual(10, player.Gold);
        }
    }
}