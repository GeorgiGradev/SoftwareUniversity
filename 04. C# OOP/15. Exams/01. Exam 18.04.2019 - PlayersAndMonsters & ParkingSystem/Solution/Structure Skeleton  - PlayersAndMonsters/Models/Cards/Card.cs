namespace PlayersAndMonsters.Models.Cards
{
    using System;
    
    using PlayersAndMonsters.Models.Cards.Contracts;

    public abstract class Card : ICard
    {
        private string name;
        private int damagePoints;
        private int healthPoints;

        protected Card(string name, int damagePoints, int healthPoints)
        {
            Name = name;
            DamagePoints = damagePoints;
            HealthPoints = healthPoints;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Card's name cannot be null or an empty string.");
                }
                this.name = value;
            }
        }

        public int DamagePoints
        {
            get => this.damagePoints;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's damage points cannot be less than zero.");
                }
                this.damagePoints = value;
            }
        }
        public int HealthPoints
        {
            get => this.healthPoints;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Card's HP cannot be less than zero.");
                }
                this.healthPoints = value;
            }
        }

    }
}
