namespace TheRace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RaceEntry
    {
        private const string ExistingDriver = "Driver {0} is already added.";
        private const string DriverInvalid = "Driver cannot be null.";
        private const string DriverAdded = "Driver {0} added in race.";
        private const int MinParticipants = 2;
        private const string RaceInvalid = "The race cannot start with less than {0} participants.";

        private Dictionary<string, UnitDriver> driver;

        public RaceEntry() // 01
        {
            this.driver = new Dictionary<string, UnitDriver>();
        }

        public int Counter // 02
            => this.driver.Count;

        public string AddDriver(UnitDriver driver)
        {
            if (driver == null) // 03
            {
                throw new InvalidOperationException(DriverInvalid);
            }

            if (this.driver.ContainsKey(driver.Name)) // 04
            {
                throw new InvalidOperationException(string.Format(ExistingDriver, driver.Name));
            }

            this.driver.Add(driver.Name, driver); // 02

            string result = string.Format(DriverAdded, driver.Name);

            return result;
        }

        public double CalculateAverageHorsePower()
        {
            if (this.driver.Count < MinParticipants) // 06
            {
                throw new InvalidOperationException(string.Format(RaceInvalid, MinParticipants));
            }

            double averageHorsePower = this.driver
                .Values
                .Select(x => x.Car.HorsePower)
                .Average();

            return averageHorsePower; // 05
        }
    }
}