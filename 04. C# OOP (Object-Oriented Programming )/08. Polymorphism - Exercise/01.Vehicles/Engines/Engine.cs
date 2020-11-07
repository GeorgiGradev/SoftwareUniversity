using _01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _01.Vehicles.Engines
{
    public static class Engine
    {
        public static void Run()
        {
            double carAdditionalConsumption = 0.9;
            double truckAdditionalFuelConsumption = 1.6;
            double truckFuelLoss = 0.95;


            string[] carInput = Console.ReadLine().Split();
            double carFuelQuantity = double.Parse(carInput[1]);
            double carFuelConsumption = double.Parse(carInput[2]);
            Car car = new Car(carFuelQuantity, carFuelConsumption);

            string[] truckInput = Console.ReadLine().Split();
            double truckFuelQuantity = double.Parse(truckInput[1]);
            double truckFuelConsumption = double.Parse(truckInput[2]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string type = input[1];
                
                if (command == "Drive")
                {
                    double distanceToDrive = double.Parse(input[2]);
                    if (type == "Car")
                    {
                        Console.WriteLine(car.Drive(distanceToDrive, carAdditionalConsumption)); ;
                    }
                    else if (type == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distanceToDrive, truckAdditionalFuelConsumption)); 
                    }
                }
                else if (command == "Refuel")
                {
                    double litersToRefuel = double.Parse(input[2]);
                    if (type == "Car")
                    {
                        car.Refuel(litersToRefuel, 1);
                    }
                    else if (type == "Truck")
                    {
                        truck.Refuel(litersToRefuel, truckFuelLoss);
                    }
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
