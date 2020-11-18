using System;
using FootballTeamGenerator.Exceptions;
using System.Linq;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }

        public Team(string name)
            : this()
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalExceptions.EmptyNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException(string.Format(GlobalExceptions.MissingPlayerExceptionMessage, playerName, this.Name));
            }

            this.players.Remove(this.players.First(p => p.Name == playerName));
        }

        public int TeamStat()
        {
            return this.players.Count == 0 
                ? 0 
                : Convert.ToInt32((this.players.Average(p => p.CalculateAverageStat())));
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TeamStat()}";
        }
    }
}
