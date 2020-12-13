namespace EasterRaces.Models.Cars.Entities
{
    using System;
    
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Utilities.Messages;

    public class MuscleCar : Car, ICar
    {
        private const int MuscleCarCubicCentimeters = 5000;
        private const int MinHorsePower = 400;
        private const int MaxHorsePower = 600;

        private int horsePower;

        public MuscleCar(string model, int horsePower) 
            : base(model, horsePower, MuscleCarCubicCentimeters, MinHorsePower, MaxHorsePower)
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
