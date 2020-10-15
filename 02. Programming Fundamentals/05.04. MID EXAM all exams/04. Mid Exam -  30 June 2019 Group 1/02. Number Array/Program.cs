using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Number_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string end = Console.ReadLine();
            int sum = 0;

            while (end != "End")
            {
                sum = 0;
                string[] tokens = end
                    .Split()
                    .ToArray();
                string command = tokens[0];

                if (command == "Switch")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >=0)
                    {
                        int number = input[index];
                        input.RemoveAt(index);
                        input.Insert(index, number * -1);
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    int value = int.Parse(tokens[2]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        int number = input[index];
                        input.RemoveAt(index);
                        input.Insert(index, value);
                    }
                }
                else if (command == "Sum")
                {
                    if (tokens[1] == "Negative")
                    {
                        List<int> negatives = input.ToList();
         
                        foreach (var item in negatives)
                        {
                            if (item < 0)
                            {
                                sum += item;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    else if (tokens[1] == "Positive")
                    {
                        List<int> positives = input.ToList();

                        foreach (var item in positives)
                        {
                            if (item > 0)
                            {
                                sum += item;
                            }
                        }
                        Console.WriteLine(sum);
                    }
                    else if (tokens[1] == "All")
                    {
                        foreach (var item in input)
                        {
                            sum += item;
                        }
                        Console.WriteLine(sum);
                    }
                }
                end = Console.ReadLine();
            }

            foreach (var item in input)
            {
                if (item >= 0)
                {
                    Console.Write($"{item} ");
                }
            }
        }
    }
}
