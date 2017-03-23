using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resistance.Domain.Exceptions;
using System;
using System.Linq;

namespace Resistance.Domain.Tests
{
    [TestClass]
    public class GameCreatorAddPlayerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameCreatorCannotAddPlayerWithNullNameTest()
        {
            GameCreator.NewGame();
            GameCreator.AddPlayer(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameCreatorCannotAddPlayerWithEmptyNameTest()
        {
            GameCreator.NewGame();
            GameCreator.AddPlayer("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GameCreatorCannotAddPlayerWithWhitespaceNameTest()
        {
            GameCreator.NewGame();
            GameCreator.AddPlayer(" ");
        }

        [TestMethod]
        [ExpectedException(typeof(MaximumNumberOfPlayersExceededException))]
        public void GameCreatorMayNotAddMoreThanTenPlayersTest()
        {
            GameCreator.NewGame();

            foreach (var numberOfPlayers in Enumerable.Range(0, 11))
            {
                GameCreator.AddPlayer("Player" + numberOfPlayers);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(PlayerAlreadyAddedException))]
        public void GameCreatorCannotAddDuplicatePlayerNamesTest()
        {
            GameCreator.NewGame();
            GameCreator.AddPlayer("Player");
            GameCreator.AddPlayer("Player");
        }
    }

    [TestClass]
    public class GameCreatorCreateTests
    {
        [TestMethod]
        [ExpectedException(typeof(InsufficientNumberOfPlayersException))]
        public void GameCreatorCannotCreateWithLessThanFivePlayersTest()
        {
            GameCreator.NewGame();

            foreach (var numberOfPlayers in Enumerable.Range(0, 4))
            {
                GameCreator.AddPlayer("Player" + numberOfPlayers);
            }

            GameCreator.Create();
        }
    }
}