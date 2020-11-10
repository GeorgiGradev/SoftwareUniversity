using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Contracts
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumptionLtrKm { get; }

        string Drive(double distanceToDrive, double additionalFuelComsumption);
        void Refuel(double littersToRefuel, double fuelLoss);
    }
}
