using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double ADDITIONAL_CONSUMPTION_PER_KM = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

        protected override double AdditionalConsumption => ADDITIONAL_CONSUMPTION_PER_KM;

        public override void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            base.Refuel(fuel * 0.95);
        }
    }
}
