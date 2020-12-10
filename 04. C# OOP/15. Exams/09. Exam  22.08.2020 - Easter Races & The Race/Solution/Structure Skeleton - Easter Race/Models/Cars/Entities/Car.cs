namespace EasterRaces.Models.Cars.Entities
{
    using System;

    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Utilities.Messages;

    public abstract class Car : ICar
    {
        private const int ModelNameSymbols = 4;
        private string model;
        private int minHorsePower;
        private int maxHorsePower;

        protected Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.Model = model;
            this.HorsePower = horsePower;
            this.CubicCentimeters = cubicCentimeters;
            this.minHorsePower = horsePower;
            this.maxHorsePower = maxHorsePower;
        }

        public string Model 
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) ||  value.Length < ModelNameSymbols)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidModel, value, ModelNameSymbols));
                }
                this.model = value;
            }
        }
        public virtual int HorsePower { get; protected set; }

        public double CubicCentimeters { get; }

        public double CalculateRacePoints(int laps)
        {
            double racePoints 
                = this.CubicCentimeters 
                / (1.0 * this.HorsePower) 
                * laps; 

            return racePoints;
        }
    }
}
