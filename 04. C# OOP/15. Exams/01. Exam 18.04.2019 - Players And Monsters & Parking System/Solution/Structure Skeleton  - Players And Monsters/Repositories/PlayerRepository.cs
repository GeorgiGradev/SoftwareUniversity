namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public class PlayerRepository : IPlayerRepository
    {
        private ICollection<IPlayer> players; // TODO Transform to DICTIONARY if it is not working properly

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }

        public int Count => this.players.Count;
        public IReadOnlyCollection<IPlayer> Players => this.players.ToList().AsReadOnly();

        public void Add(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            string playerName = player.Username;
            if (players.Any(x=>x.Username == playerName))
            {
                throw new ArgumentException($"Player {playerName} already exists!");
            }
            players.Add(player);
        }

        public bool Remove(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            return players.Remove(player);
        }

        public IPlayer Find(string username)
        {
            IPlayer player = null;
            if (players.Any(x => x.Username == username))
            {
                player = players.FirstOrDefault(x => x.Username == username);
            }
            return player;
        }
    }
}
