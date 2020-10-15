using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace _08.CarSalesman
{
    class Engine
    {
        private string model;
        private double power;
        private double displacement;
        private string efficiency;

        public Engine (string model, double power, double displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;

        }
        public Engine (string model, double power, double displacement)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
        }

        public Engine (string model, double power, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Efficiency = efficiency;
        }

        public Engine (string model, double power)
        {
            this.Model = model;
            this.Power = power;
        }


        public string Model { get; set; }
        public double Power { get; set; }
        public double Displacement { get; set; } = -1;
        public string Efficiency { get; set; } = "n/a";
    }
}
