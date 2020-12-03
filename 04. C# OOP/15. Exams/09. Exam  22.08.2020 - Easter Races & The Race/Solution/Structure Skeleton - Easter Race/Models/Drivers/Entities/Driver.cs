namespace EasterRaces.Models.Drivers.Entities
{
    using System;

    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Utilities.Messages;

    public class Driver : IDriver
    {
        private const int ModelNameSymbols = 5;
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name 
        {
            get => this.name;
            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length < ModelNameSymbols)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, ModelNameSymbols));
                }
                this.name = value;
            }
        }
        public ICar Car { get; private set; }
        public int NumberOfWins { get; private set; }
        public bool CanParticipate { get; private set; }

        public void AddCar(ICar car)
        {
            if (car is null)
            {
                throw new ArgumentException(ExceptionMessages.CarInvalid);
            }
            this.Car = car;
            this.CanParticipate = true;
        }
        public void WinRace()
        {
            this.NumberOfWins++;
        }
    }
}
