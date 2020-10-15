using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> list = new List<Car>();
            Car car = new Car();
            for (int i = 0; i < n; i++)
            {
                car = new Car();
                string[] tokens = Console.ReadLine().Split();
                car.Model = tokens[0];
                car.FuelAmount = double.Parse(tokens[1]);
                car.FuelConsumptionPerKM = double.Parse(tokens[2]);
                list.Add(car);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else
                {
                    string[] tokens = input.Split();
                    string model = tokens[1];
                    double amountOfKm = double.Parse(tokens[2]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (model == list[i].Model)
                        {
                            if (list[i].Calculate(list[i].FuelAmount, list[i].FuelConsumptionPerKM, amountOfKm) == false)
                            {
                                Console.WriteLine("Insufficient fuel for the drive");
                            }
                            else
                            {
                                list[i].FuelAmount -= list[i].FuelConsumptionPerKM * amountOfKm;
                                list[i].TravelledDistance += amountOfKm;
                            }
                        }
                    }
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
