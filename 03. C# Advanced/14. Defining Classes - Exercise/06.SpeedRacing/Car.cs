using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKm;
        private double travelledDistance;


        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKM { get; set; }
        public double TravelledDistance { get; set; }
         

        public bool Calculate(double fuelAmount, double fuelConsumption, double travelledDistance)
        {
            bool isFuelEnough = false;

            if (fuelAmount >= travelledDistance * fuelConsumption)
            {
                isFuelEnough = true;
            }

            return isFuelEnough;
        }

    }
}
