using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Resistance.Domain.Exceptions;
using System;

namespace Resistance.Domain.Tests
{
    [TestClass]
    public class GameConstructorTests
    {
        private struct Numbers
        {
            public int NumberOfResistanceMembers;
            public int NumberOfSpies;

            public Numbers(int numberOfResistanceMembers, int numberOfSpies)
            {
                this.NumberOfResistanceMembers = numberOfResistanceMembers;
                this.NumberOfSpies = numberOfSpies;
            }
        }

        [TestMethod]
        public void GameHasCorrectNumberOfResistanceMembersAndSpiesTest()
        {
            var scenarios = new Dictionary<int, Numbers>()
            {
                { 5, new Numbers(3, 2) },
                { 6, new Numbers(4, 2) },
                { 7, new Numbers(4, 3) },
                { 8, new Numbers(5, 3) },
                { 9, new Numbers(6, 3) },
                { 10, new Numbers(6, 4) }
            };

            GameCreator.NewGame();

            foreach (var numberOfPlayers in Enumerable.Range(1, 10))
            {
                GameCreator.AddPlayer("Player" + numberOfPlayers);

                if (numberOfPlayers < 5) continue;

                var game = GameCreator.Create();

                Assert.AreEqual(numberOfPlayers, game.NumberOfPlayers);
                Assert.AreEqual(scenarios[numberOfPlayers].NumberOfResistanceMembers, game.NumberOfResistanceMembers);
                Assert.AreEqual(scenarios[numberOfPlayers].NumberOfResistanceMembers, game.Resistance.Count());
                Assert.AreEqual(scenarios[numberOfPlayers].NumberOfSpies, game.NumberOfSpies);
                Assert.AreEqual(scenarios[numberOfPlayers].NumberOfSpies, game.Spies.Count());
            }
        }

        [TestMethod]
        public void GameMaintainsPlayerOrderTest()
        {
            GameCreator.NewGame();

            foreach (int numberOfPlayers in Enumerable.Range(0, 10))
            {
                GameCreator.AddPlayer("Player" + numberOfPlayers);
            }

            var game = GameCreator.Create();

            foreach (int numberOfPlayers in Enumerable.Range(0, 10))
            {
                Assert.AreEqual("Player" + numberOfPlayers, game.AllPlayers[numberOfPlayers].Name);
            }
        }
    }
}