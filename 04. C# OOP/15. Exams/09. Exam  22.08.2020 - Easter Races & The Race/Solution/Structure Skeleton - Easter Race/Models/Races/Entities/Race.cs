namespace EasterRaces.Models.Races.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Models.Races.Contracts;
    using EasterRaces.Utilities.Messages;

    public class Race : IRace
    {
        private const int MinNumberOfLaps = 1;
        private const int RacelNameSymbols = 5;
        private string name;
        private int laps;
        private readonly ICollection<IDriver> drivers;

        public Race(string name, int laps)
        {
            Name = name;
            Laps = laps;
            this.drivers = new List<IDriver>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < RacelNameSymbols)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidName, value, RacelNameSymbols));
                }
                this.name = value;
            }
        }

        public int Laps 
        {
            get => this.laps;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidNumberOfLaps, MinNumberOfLaps));
                }
                this.laps = value;
            }
        }

        public IReadOnlyCollection<IDriver> Drivers => this.drivers.ToList();

        public void AddDriver(IDriver driver)
        {
            if (driver is null)
            {
                throw new ArgumentException(ExceptionMessages.DriverInvalid);
            }
            if (driver.CanParticipate == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverNotParticipate, driver.Name));
            }
            if (drivers.Any(x=>x.Name ==  driver.Name))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DriverAlreadyAdded, driver.Name, this.Name));
            }
            this.drivers.Add(driver);
        }
    }
}
