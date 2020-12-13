namespace EasterRaces.Models.Cars.Entities
{
    using System;
   
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Utilities.Messages;

    public class SportsCar : Car, ICar
    {
        private const int SportsCarCubicCentimeters = 3000;
        private const int MinHorsePower = 250;
        private const int MaxHorsePower = 450;

        private int horsePower;

        public SportsCar(string model, int horsePower) 
            : base(model, horsePower, SportsCarCubicCentimeters, MinHorsePower, MaxHorsePower)
        {
        }

        public override int HorsePower
        {
            get => this.horsePower;
            protected set
            {
                if (value < MinHorsePower || value > MaxHorsePower)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidHorsePower, value));
                }
                this.horsePower = value;
            }
        }
    }
}
