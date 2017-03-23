using System.Collections.Generic;

namespace Resistance.Domain
{
    public class GameCreator
    {
        private List<Player> _players;

        public GameCreator()
        {
            _players = new List<Player>();
        }

        /// <summary>
        /// Ordered insertion of unique players
        /// </summary>
        /// <param name="playerName"></param>
        /// <returns></returns>
        public bool AddPlayer(string playerName)
        {
            var player = new Player(playerName);

            if (_players.Contains(player)) return false;

            _players.Add(player);

            return true;
        }
        
        public Game Create()
        {
            return new Game(_players);
        }
    }
}