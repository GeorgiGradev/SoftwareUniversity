
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Schema;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Engine> engineList = new HashSet<Engine>();
            HashSet<Car> carList = new HashSet<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] engineArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = engineArgs[0];
                double power = double.Parse(engineArgs[1]);

                if (engineArgs.Length == 2)
                {
                    Engine engine = new Engine(model, power);
                    engineList.Add(engine);
                }
                else if (engineArgs.Length == 3)
                {
                    string thirgArgument = engineArgs[2];
                    if (Char.IsDigit(thirgArgument[0]))
                    {
                        double displacement = double.Parse(thirgArgument);
                        Engine engine = new Engine(model, power, displacement);
                        engineList.Add(engine);
                    }
                    else
                    {
                        string efficiency = thirgArgument;
                        Engine engine = new Engine(model, power, efficiency);
                        engineList.Add(engine);
                    }
                }
                else if (engineArgs.Length == 4)
                {
                    double displacement = double.Parse(engineArgs[2]);
                    string efficiency = engineArgs[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engineList.Add(engine);
                }
            }

            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                string[] carArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                string engine = carArgs[1];

                if (carArgs.Length == 2)
                {
                    Car car = new Car(model, engine);
                    carList.Add(car);
                }
                else if (carArgs.Length == 3)
                {
                    string thirgArgument = carArgs[2];
                    if (Char.IsDigit(thirgArgument[0]))
                    {
                        double weight = double.Parse(thirgArgument);
                        Car car = new Car(model, engine, weight);
                        carList.Add(car);
                    }
                    else
                    {
                        string color = thirgArgument;
                        Car car = new Car(model, engine, color);
                        carList.Add(car);
                    }
                }
                else if (carArgs.Length == 4)
                {
                    double weight = double.Parse(carArgs[2]);
                    string color = carArgs[3];
                    Car car = new Car(model, engine, weight, color);
                    carList.Add(car);
                }
            }

            foreach (var car in carList)
            {
                foreach (var engine in engineList)
                {
                    if (engine.Model == car.Engine)
                    {
                  


                        Console.WriteLine($"{car.Model}:");
                        Console.WriteLine($"  {car.Engine}:");
                        Console.WriteLine($"    Power: {engine.Power}");
                        if (engine.Displacement == -1)
                        {
                            Console.WriteLine($"    Displacement: n/a");
                        }
                        else
                        {
                            Console.WriteLine($"    Displacement: {engine.Displacement}");
                        }
                        Console.WriteLine($"    Efficiency: {engine.Efficiency}");
                        if (car.Weight == -1)
                        {
                            Console.WriteLine($"  Weight: n/a");
                        }
                        else
                        {
                            Console.WriteLine($"  Weight: {car.Weight}");
                        }
                        Console.WriteLine($"  Color: {car.Color}");
                    }
                }
            }









            //foreach (var car in carList)
            //{
            //    foreach (var engine in engineList)
            //    {
            //        if (engine.Model == car.Engine)
            //        {
            //            Console.WriteLine($"{car.Model}:");
            //            Console.WriteLine($"  {car.Engine}:");
            //            Console.WriteLine($"    Power: {engine.Power}");
            //            if (engine.Displacement == -1)
            //            {
            //                Console.WriteLine($"    Displacement: n/a");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"    Displacement: {engine.Displacement}");
            //            }
            //            Console.WriteLine($"    Efficiency: {engine.Efficiency}");
            //            if (car.Weight == -1)
            //            {
            //                Console.WriteLine($"  Weight: n/a");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"  Weight: {car.Weight}");
            //            }
            //            Console.WriteLine($"  Color: {car.Color}");
            //        }
            //    }
            //}

        }
    }
}
