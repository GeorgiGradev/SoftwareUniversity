using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string model = string.Empty;
            double engineSpeed = 0;
            double enginePower = 0;
            double cargoWeight = 0;
            string cargoType = string.Empty;
            double tire1preassure = 0;
            double tire2preassure = 0;
            double tire3preassure = 0;
            double tire4preassure = 0;
            

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire tire = new Tire(tire1preassure, tire2preassure, tire3preassure, tire4preassure);
            Car car = new Car(model, engine, cargo, tire);
            List<Car> list = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                model = input[0];
                engineSpeed = double.Parse(input[1]);
                enginePower = double.Parse(input[2]);
                cargoWeight = double.Parse(input[3]);
                cargoType = input[4];
                tire1preassure = double.Parse(input[5]);
                tire2preassure = double.Parse(input[7]);
                tire3preassure = double.Parse(input[9]);
                tire4preassure = double.Parse(input[11]);
                engine = new Engine(engineSpeed, enginePower);
                cargo = new Cargo(cargoWeight, cargoType);
                tire = new Tire(tire1preassure, tire2preassure, tire3preassure, tire4preassure);
                car = new Car(model, engine, 
                   cargo, tire);
                list.Add(car);
            }
            string type = Console.ReadLine();


            if (type == "fragile")
            {
                List<Car> output = list
                    .Where(x => x.Cargo.CargoType == "fragile"
                    && x.Tire.AverageTirePressure(x.Tire.Tire1preassure, x.Tire.Tire2preassure, x.Tire.Tire3preassure, x.Tire.Tire4preassure) < 1).ToList();

                Console.WriteLine(string.Join(Environment.NewLine, output));


            }
            else if (type == "flamable")
            {
                List<Car> output = list
                    .Where(x => x.Cargo.CargoType == "flamable"
                    && x.Engine.EnginePower > 250).ToList();


                Console.WriteLine(string.Join(Environment.NewLine, output));

            }
        }
    }
}
