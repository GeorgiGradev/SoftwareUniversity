using _01.Vehicles.Contracts;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {


        public Car(double fuelQuantity, double fuelConsumptionLtrKm) 
            : base(fuelQuantity, fuelConsumptionLtrKm)
        {

        }
       
        public override string Drive(double distanceToDrive, double carAdditionalConsumption)
        {
            return $"Car" + base.Drive(distanceToDrive, carAdditionalConsumption);
        }
        public override void Refuel(double littersToRefuel, double carFuelLoss)
        {
            base.Refuel(littersToRefuel, carFuelLoss);
        }

        public override string ToString()
        {
            return $"Car: {this.FuelQuantity:f2}";
        }
    }
}
