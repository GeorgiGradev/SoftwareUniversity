using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(currArr[0]), double.Parse(currArr[1])),
                    new Tire(int.Parse(currArr[2]), double.Parse(currArr[3])),
                    new Tire(int.Parse(currArr[4]), double.Parse(currArr[5])),
                    new Tire(int.Parse(currArr[6]), double.Parse(currArr[7]))
                };

                tires.Add(currTires);

                command = Console.ReadLine();
            }

            var engines = new List<Engine>();

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var engine = new Engine(int.Parse(currArr[0]), double.Parse(currArr[1]));
                engines.Add(engine);

                command = Console.ReadLine();
            }

            var cars = new List<Car>();

            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var make = currArr[0];
                var model = currArr[1];
                var year = int.Parse(currArr[2]);
                var fuelQuantity = double.Parse(currArr[3]);
                var fuelCapacity = double.Parse(currArr[4]);
                var engineIndex = int.Parse(currArr[5]);
                var tireIndex = int.Parse(currArr[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count) && (tireIndex >= 0 && tireIndex < tires.Count))
                {
                    var car = new Car(make, model, year, fuelQuantity, fuelCapacity, engines[engineIndex], tires[tireIndex]);
                    cars.Add(car);
                }

                command = Console.ReadLine();
            }

            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
