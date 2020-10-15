using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int targets = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                int index = int.Parse(command);
                if (input.Count - 1 >= index)
                {

                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] > -1 && input[i] <= input[index] && i != index)
                        {
                            input[i] = input[i] + input[index];
                        }
                        else if (input[i] > input[index] && i != index)
                        {
                            input[i] = input[i] - input[index];
                        }
                    }
                    input[index] = -1;
                    targets++;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {targets} -> {string.Join(" ", input)}");
        }
    }
}
