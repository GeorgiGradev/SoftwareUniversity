using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
                    .Split()
                    .ToList();

                string name = input[1];

                if (input[0] == "register")
                {
                    string plate = input[2];
                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                   else if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (dict.ContainsKey(name))
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            
        }
    }
}
