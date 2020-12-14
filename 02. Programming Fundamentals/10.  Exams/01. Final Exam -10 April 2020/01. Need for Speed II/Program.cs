using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _01._Need_for_Speed_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();



            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("|");
                string car = tokens[0];
                double mileage = int.Parse(tokens[1]);
                double fuel = int.Parse(tokens[2]);

                if (!dict.ContainsKey(car))
                {
                    dict.Add(car, new List<double> { 0, 0 });
                }
                dict[car][0] += mileage;
                dict[car][1] += fuel;
            }
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split(" : ");
                string command = tokens[0];
                string car = tokens[1];

                if (command == "Drive")
                {
                    int distanceAdded = int.Parse(tokens[2]);
                    double fuelNeeded = double.Parse(tokens[3]);

                    if (dict[car][1] - fuelNeeded >= 0)
                    {
                        dict[car][1] -= fuelNeeded;
                        dict[car][0] += distanceAdded;
                        Console.WriteLine($"{car} driven for {distanceAdded} kilometers. {fuelNeeded} liters of fuel consumed.");
                        if (dict[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            dict.Remove(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                }
                else if (command == "Refuel")
                {
                    double fuelRefilled = int.Parse(tokens[2]);
                    if (dict[car][1] + fuelRefilled <= 75)
                    {
                        dict[car][1] += fuelRefilled;
                        Console.WriteLine($"{car} refueled with {fuelRefilled} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {75 - dict[car][1]} liters");
                        dict[car][1] = 75;
                    }
                }
                else if (command == "Revert")
                {
                    double kilometers = int.Parse(tokens[2]);
                    if (dict[car][0] - kilometers < 10000)
                    {
                        dict[car][0] = 10000;
                    }
                    else
                    {
                        dict[car][0] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }
            }
            foreach (var item in dict.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            }
        }
    }
}
