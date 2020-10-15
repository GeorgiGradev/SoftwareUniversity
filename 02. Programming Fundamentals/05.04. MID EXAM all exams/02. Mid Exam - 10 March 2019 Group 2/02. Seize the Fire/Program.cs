using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Seize_the_Fire
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('#')
                .ToArray();
            int water = int.Parse(Console.ReadLine());
            int totalFire = 0;
            double effort = 0;
            List<int> output = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string[] tokens = input[i]
                    .Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string typeOfFire = tokens[0];
                int value = int.Parse(tokens[1]);

                if ((typeOfFire == "High" && (value >= 81 && value <= 125))
                    || (typeOfFire == "Medium" && (value >= 51 && value <= 80))
                    ||(typeOfFire == "Low" && (value >= 1 && value <= 50))
                    )
                {
                    
                    if ( water - value < 0)
                    {
                        continue;
                    }

                    water -= value;
                    totalFire += value;
                    output.Add(value);
                }
            }
            effort = (double)totalFire / 4;
            Console.WriteLine("Cells:");
            foreach (var item in output)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }
}
