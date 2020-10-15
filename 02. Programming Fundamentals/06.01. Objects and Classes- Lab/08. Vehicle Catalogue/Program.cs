using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        static void Main(string[] args)
        {
            List<Car> outputCar = new List<Car>();
            List<Truck> outputTruck = new List<Truck>();
            bool isCar = false;
            bool isTruck = false;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                List<string> input = command.Split('/').ToList();
                
                if (input[0] == "Car")
                {
                    string brand = input[1];
                    string model = input[2];
                    string horsePower = input[3];
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;
                    outputCar.Add(car);
                    isCar = true;
                }
                else if (input[0] == "Truck")
                {
                    string brand = input[1];
                    string model = input[2];
                    string weight = input[3];
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;
                    outputTruck.Add(truck);
                    isTruck = true;
                }
            }
            List<Car> sortedCars = outputCar.OrderBy(sort => sort.Brand).ToList();
            List<Truck> sortedTrucks = outputTruck.OrderBy(sort => sort.Brand).ToList();

            if (isCar)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in sortedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (isTruck)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in sortedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
