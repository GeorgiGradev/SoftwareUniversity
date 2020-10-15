using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> newList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                if (input.Count == 3)
                {
                    if (newList.Contains(input[0]) == false)
                    {
                        newList.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                else if (input.Count == 4)
                {
                    if (newList.Contains(input[0]))
                    {
                        newList.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < newList.Count; i++)
            {
                Console.Write(newList[i]);
                Console.WriteLine();
            }
        }
    }
}

