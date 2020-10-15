using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private string engine;
        private double weight;
        private string color;



        public Car(string model, string engine, double weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, string engine, double weight)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
        }

        public Car(string model, string engine, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = color;
        }

        public Car(string model, string engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public string Model { get; set; }

        public string Engine { get; set; }

        public double Weight { get; set; } = - 1;

        public string Color { get; set; } = "n/a";

    }
}

