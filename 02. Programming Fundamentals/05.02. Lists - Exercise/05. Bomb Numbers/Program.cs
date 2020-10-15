using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> bombPower = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bomb = bombPower[0];
            int power = bombPower[1];

            while (input.Contains(bomb))
            {
                for (int i = 0; i < power; i++)
                {
                    int index = input.IndexOf(bomb);
                    if (index - 1 >= 0)
                    {
                        input.RemoveAt(index - 1);
                    }
                }

                for (int i = 0; i < power; i++)
                {
                    int index = input.IndexOf(bomb);
                    if (index + 1 <= input.Count - 1)
                    {
                        input.RemoveAt(index + 1);
                    }
                }

                input.Remove(bomb);
            }

            Console.WriteLine(input.Sum());
        }
    }
}
