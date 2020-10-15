using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _07.RawData
{
    public class Engine
    {
        private double engineSpeed;
        private double enginePower;


        public Engine(double engineSpeed, double enginePower )
        {
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
        }

        public double EngineSpeed { get; set; }
        public double EnginePower { get; set; }
    }
}
