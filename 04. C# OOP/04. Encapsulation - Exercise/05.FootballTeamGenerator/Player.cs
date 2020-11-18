using FootballTeamGenerator.Exceptions;
using System;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private Stats stats;

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
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

        private Stats Stats
        {
            set
            {
                this.stats = value;
            }
        }

        public int CalculateAverageStat()
        {
            int averageStat = (int)Math
                .Round((this.stats.Endurance +
                this.stats.Sprint + 
                this.stats.Dribble + 
                this.stats.Passing + 
                this.stats.Shooting) / 5.0);

            return averageStat;
        }
    }
}
