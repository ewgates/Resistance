using System;
using System.Collections.Generic;
using System.Linq;

namespace Resistance.Domain
{
    public class Game
    {
        public List<Player> AllPlayers { get; }
        public int NumberOfPlayers { get; }
        public IEnumerable<Spy> Spies => AllPlayers.Where(p => p.Group == Group.Spies).Select(p => new Spy(p));
        public int NumberOfSpies { get; }
        public IEnumerable<ResistanceMember> Resistance => AllPlayers.Where(p => p.Group == Group.Resistance).Select(p => new ResistanceMember(p));
        public int NumberOfResistanceMembers { get; }
        public MissionLeader MissionLeader { get; }

        internal Game(List<Player> players)
        {
            AllPlayers = players;

            // Save calculated frequently reused values that remain constant
            NumberOfPlayers = AllPlayers.Count;
            NumberOfSpies = (int)Math.Ceiling((double)NumberOfPlayers / 3);
            NumberOfResistanceMembers = NumberOfPlayers - NumberOfSpies;

            // Randomly assign group role
            Random random = new Random();

            var minRandom = 0;
            var maxRandom = NumberOfPlayers;

            for (var playerIndex = 0; playerIndex < NumberOfPlayers; playerIndex++)
            {
                if (random.Next(minRandom, maxRandom) < NumberOfResistanceMembers)
                {
                    minRandom++;
                    AllPlayers[playerIndex].Group = Group.Resistance;
                }
                else
                {
                    maxRandom--;
                    AllPlayers[playerIndex].Group = Group.Spies;
                }
            }
        }
    }
}