using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            int index = 0;
            while (command != "Love!")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                int lenght = int.Parse(tokens[1]);

                while (lenght > 0)
                {
                    lenght--;
                    index++;
                    if (index > input.Count - 1)
                    {
                        index = 0;
                        break;
                    }
                }
                if (input[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    command = Console.ReadLine();
                    continue;
                }

                input[index] -= 2;
                if (input[index] <= 0)
                {
                    input[index] = 0;
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {index}.");
            if (input.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int houseCount = 0;
                foreach (var item in input)
                {
                    if (item != 0)
                    {
                        houseCount++;
                    }
                }
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
