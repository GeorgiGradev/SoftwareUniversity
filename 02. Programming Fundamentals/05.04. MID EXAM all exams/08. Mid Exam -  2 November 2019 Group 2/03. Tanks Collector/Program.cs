using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Tanks_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ")
                .ToList();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                if (tokens[0] == "Add")
                {
                    string tankName = tokens[1];
                    if (input.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else
                    {
                        input.Add(tankName);
                        Console.WriteLine("Tank successfully bought");
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    string tankName = tokens[1];
                    if (input.Contains(tankName))
                    {
                        input.Remove(tankName);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Tank not found");
                    }
                }
                else if (tokens[0] == "Remove At")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                        Console.WriteLine("Tank successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
                else if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[1]);
                    string tankName = tokens[2];
                    if (input.Count - 1 >= index && index >= 0 && input.Contains(tankName))
                    {
                        Console.WriteLine("Tank is already bought");
                    }
                    else if (input.Count - 1 >= index && index >= 0 && !input.Contains(tankName))
                    {
                        input.Insert(index, tankName);
                        Console.WriteLine("Tank successfully bought");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
