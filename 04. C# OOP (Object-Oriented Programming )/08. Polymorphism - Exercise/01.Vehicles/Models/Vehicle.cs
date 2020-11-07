using _01.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public Vehicle(double fuelQuantity, double fuelConsumptionLtrKm)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumptionLtrKm = fuelConsumptionLtrKm;
        }

        public double FuelQuantity { get; private set;  }

        public double FuelConsumptionLtrKm { get; private set; }

        public virtual string Drive(double distanceToDrive, double additionalFuelComsumption)
        {
            if (this.FuelQuantity - (distanceToDrive * (this.FuelConsumptionLtrKm + additionalFuelComsumption)) >= 0)
            {
                this.FuelQuantity -= (distanceToDrive * (this.FuelConsumptionLtrKm + additionalFuelComsumption));
                return $" travelled {distanceToDrive} km";
            }
            else
            {
                return " needs refueling"; 
            }
        }

        public virtual void Refuel(double littersToRefuel, double fuelLoss)
        {
            this.FuelQuantity += littersToRefuel * fuelLoss;
        }
    }
}
