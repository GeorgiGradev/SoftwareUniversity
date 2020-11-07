using System;

using Vehicles.Models.Contracts;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            set
            {
                if (value < this.fuelQuantity)
                {
                    this.fuelQuantity = 0;
                }

                this.tankCapacity = value;
            }
        }

        protected abstract double AdditionalConsumption { get; }

        public string DriveEmpty(double distance)
        {
            double requiredFuel = this.FuelQuantity - this.FuelConsumption * distance;

            if (requiredFuel >= 0)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public string Drive(double distance)
        {
            double requiredFuel = this.FuelQuantity - (this.FuelConsumption + this.AdditionalConsumption) * distance;

            if (requiredFuel >= 0)
            {
                this.FuelQuantity -= (this.FuelConsumption + this.AdditionalConsumption) * distance;

                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }

            this.FuelQuantity += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
