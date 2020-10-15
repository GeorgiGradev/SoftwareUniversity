using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];
                string[] clothes = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k < clothes.Length; k++)
                {
                    if (!dict.ContainsKey(color))
                    {
                        dict.Add(color, new Dictionary<string, int>());
                    }
                    if (!dict[color].ContainsKey(clothes[k]))
                    {
                        dict[color].Add(clothes[k], 0);
                    }
                    dict[color][clothes[k]]++;
                }
            }

            string[] toFind = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorToFind = toFind[0];
            string clothesToFind = toFind[1];

            foreach (var (key, value) in dict)
            {

                string color = key;
                Dictionary<string, int> clothes = value;

                Console.WriteLine($"{color} clothes:");

                foreach (var item in clothes)
                {
                    string piece = item.Key;
                    int quantity = item.Value;

                    if (color == colorToFind && piece == clothesToFind)
                    {
                        Console.WriteLine($"* {piece} - {quantity} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {piece} - {quantity}");
                    }
                }
            }
        }
    }
}
