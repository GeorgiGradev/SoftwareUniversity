using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Cargo
    {
        private double cargoWeight;
        private string cargoType;

        public Cargo(double cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }


        public double CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
