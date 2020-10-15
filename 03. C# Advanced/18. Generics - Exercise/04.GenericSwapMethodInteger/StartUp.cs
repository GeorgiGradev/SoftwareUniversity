using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                list.Add(element);
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            SwapMe<int>(list, indexes[0], indexes[1]);
        }
        public static void SwapMe<T>(List<T> list, int index1, int index2)
        {
            T element1 = list[index1];
            T element2 = list[index2];

            list.RemoveAt(index1);
            list.Insert(index1, element2);
            list.RemoveAt(index2);
            list.Insert(index2, element1);

            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
