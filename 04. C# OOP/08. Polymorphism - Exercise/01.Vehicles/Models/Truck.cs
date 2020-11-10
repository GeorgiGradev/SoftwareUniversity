using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionLtrKm) 
            : base(fuelQuantity, fuelConsumptionLtrKm)
        {

        }


        public override string Drive(double distanceToDrive, double truckAdditionalConsumption)
        {
            return $"Truck" + base.Drive(distanceToDrive, truckAdditionalConsumption);
        }
        public override void Refuel(double littersToRefuel, double truckFuelLoss)
        {
            base.Refuel(littersToRefuel,truckFuelLoss);
        }

        public override string ToString()
        {
            return $"Truck: {this.FuelQuantity:f2}";
        }
    }

}
