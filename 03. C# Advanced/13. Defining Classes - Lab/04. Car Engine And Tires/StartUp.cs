using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(1, 2.5)
            };

            Engine engine = new Engine(560, 6300);
            Car car = new Car("Lambo", "Urus", 2019, 250, 9, engine, tires);
            Console.WriteLine($"{car.Model} {car.Make} {car.Year} {car.Engine.CubicCapacity} {car.Engine.HorsePower}");

            foreach (var tire in tires)
            {
                Console.WriteLine($"{tire.Pressure} {tire.Year}");
            }
        }
    }
}
