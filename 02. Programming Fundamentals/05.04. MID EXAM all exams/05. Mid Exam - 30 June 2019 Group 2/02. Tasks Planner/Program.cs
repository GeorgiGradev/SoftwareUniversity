using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            string finish = Console.ReadLine();

            while (finish != "End")
            {
                string[] tokens = finish
                    .Split()
                    .ToArray();

                string command = tokens[0];

                if (command == "Complete")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, 0);
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(tokens[1]);
                    double time = double.Parse(tokens[2]);
                    if (input.Count - 1 >= index && index >= 0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, time);
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(tokens[1]);
                    if (input.Count - 1 >= index && index >=0)
                    {
                        input.RemoveAt(index);
                        input.Insert(index, -1);
                    }
                }
                else if (command == "Count")
                {
                    if (tokens[1] == "Completed")
                    {
                        int count = 0;
                        foreach (var item in input)
                        {
                            if (item == 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    else if (tokens[1] == "Incomplete")
                    {
                        int count = 0;
                        foreach (var item in input)
                        {
                            if (item > 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                    else if (tokens[1] == "Dropped")
                    {
                        int count = 0;
                        foreach (var item in input)
                        {
                            if (item < 0)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine(count);
                    }
                }

                finish = Console.ReadLine();
            }
            input.RemoveAll(x => x <= 0);
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
