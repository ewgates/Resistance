using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resistance.Domain.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GameTest()
        {
            var numberOfPlayers = 9;
            var numberOfResistanceMembers = 6;
            var numberOfSpies = 3;

            var players = new List<Player>()
            {
                new Player("Player0"),
                new Player("Player1"),
                new Player("Player2"),
                new Player("Player3"),
                new Player("Player4"),
                new Player("Player5"),
                new Player("Player6"),
                new Player("Player7"),
                new Player("Player8"),
                //new Player("Player9")
            };
            var game = new Game(players);

            Assert.AreEqual(numberOfPlayers, game.NumberOfPlayers);
            Assert.AreEqual(numberOfResistanceMembers, game.NumberOfResistanceMembers);
            Assert.AreEqual(numberOfResistanceMembers, game.Resistance.Count());
            Assert.AreEqual(numberOfSpies, game.NumberOfSpies);
            Assert.AreEqual(numberOfSpies, game.Spies.Count());
        }
    }
}
