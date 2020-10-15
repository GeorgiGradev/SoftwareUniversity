using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;


        public Tire (int year, double preasure)
        {
            this.Year = year;
            this.Pressure = preasure;
        }


        public int Year { get; set; }

        public double Pressure { get; set; }
    }
}
