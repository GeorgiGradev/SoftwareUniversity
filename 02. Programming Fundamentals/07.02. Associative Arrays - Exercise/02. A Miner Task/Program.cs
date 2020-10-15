using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int quantity = 0;
            string temp = string.Empty;
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                else
                {
                    count++;
                    if (count % 2 != 0) // когато input е string
                    {
                        if (!dict.ContainsKey(input))
                        {
                            dict[input] = 0;
                        }
                    }
                    else // когато input е число
                    {
                        quantity = int.Parse(input);
                        dict[temp] += quantity;
                    }
                    temp = input;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
