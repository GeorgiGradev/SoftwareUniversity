using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace _07.RawData
{
    public class Tire
    {
        private double tire1preassure;
        private double tire2preassure;
        private double tire3preassure;
        private double tire4preassure;


        public Tire(double tire1preassure, double tire2preassure, double tire3preassure, double tire4preassure)
                {
            this.Tire1preassure = tire1preassure;
            this.Tire2preassure = tire2preassure;
            this.Tire3preassure = tire3preassure;
            this.Tire4preassure = tire4preassure;
        }

    public double Tire1preassure { get; set; }

        public double Tire2preassure { get; set; }

        public double Tire3preassure { get; set; }

        public double Tire4preassure { get; set; }



        public double AverageTirePressure(double tire1preassure, double tire2preassure, double tire3preassure, double tire4preassure)
        {
            double averageTirePressure = (tire1preassure + tire2preassure + tire3preassure + tire4preassure) / 4;


            return averageTirePressure;
        }

    }
}
