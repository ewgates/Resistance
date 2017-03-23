using System.Collections.Generic;
using Resistance.Domain.Exceptions;

namespace Resistance.Domain
{
    public static class GameCreator
    {
        private static List<Player> _players;

        /// <summary>
        /// 
        /// </summary>
        public static void NewGame()
        {
            _players = new List<Player>();
        }

        /// <summary>
        /// Ordered insertion of unique players
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public static void AddPlayer(string playerName)
        {
            if (_players.Count >= 10) throw new MaximumNumberOfPlayersExceededException();
            
            var player = new Player(playerName);
            
            if (_players.Contains(player)) throw new PlayerAlreadyAddedException();

            _players.Add(player);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Game Create()
        {
            if (_players.Count < 5) throw new InsufficientNumberOfPlayersException();

            return new Game(_players);
        }
    }
}