using System;
using System.Collections.Generic;
using System.Text;

namespace _07._01.RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;


        public Car(string model, int speed, int power, int weight, string type, double tire1pressure, int tire1age, double tire2pressure, int tire2age, double tire3pressure, int tire3age, double tire4pressure, int tire4age )
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.tires = new List<Tire>
            {
                new Tire (tire1age, tire1pressure),
                new Tire (tire2age, tire2pressure),
                new Tire (tire3age, tire3pressure),
                new Tire (tire4age, tire4pressure)
            };
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }
        }

        public override string ToString()
        {
            return this.Model;
        }


    }
}
