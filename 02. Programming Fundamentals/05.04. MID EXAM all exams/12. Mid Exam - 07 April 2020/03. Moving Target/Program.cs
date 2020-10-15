using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command
                    .Split()
                    .ToArray();

                if (tokens[0] == "Shoot")
                {
                    int index = int.Parse(tokens[1]);
                    int power = int.Parse(tokens[2]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input[index] -= power;
                        if(input[index] <= 0)
                        {
                            input.RemoveAt(index);
                        }
                    }
                }
                else if (tokens[0] == "Add")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (tokens[0] == "Strike")
                {
                    int index = int.Parse(tokens[1]);
                    int radius = int.Parse(tokens[2]);
                    int index1 = index - radius;
                    int index2 = index + radius;
                    if (input.Count - 1 >= index2 && index1 >= 0 )
                    {
                        for (int i = index2; i >= index1; i--)
                        {
                            input.RemoveAt(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", input));
        }
    }
}
