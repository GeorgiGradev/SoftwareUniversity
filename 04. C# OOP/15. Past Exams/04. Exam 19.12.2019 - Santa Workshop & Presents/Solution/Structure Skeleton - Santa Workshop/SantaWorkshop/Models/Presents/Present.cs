namespace SantaWorkshop.Models.Presents
{
    using System;
    using SantaWorkshop.Models.Presents.Contracts;
    using SantaWorkshop.Utilities.Messages;

    public class Present : IPresent
    {
        private string name;
        private int energyRequired;

        public Present(string name, int energyRequired)
        {
            Name = name;
            EnergyRequired = energyRequired;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPresentName);
                }
                this.name = value;
            }
        }

        public int EnergyRequired
        {
            get => this.energyRequired;
            private set
            {
                this.energyRequired = value < 0 ? 0 : value;
            }
        }

        public void GetCrafted()
        {
            this.EnergyRequired -= 10;
        }

        public bool IsDone() => this.energyRequired == 0;
    }
}
