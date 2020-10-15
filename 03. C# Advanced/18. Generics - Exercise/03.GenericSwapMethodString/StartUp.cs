using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                list.Add(element);
            }
            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            SwapMethod<string>(list, indexes[0], indexes[1]);
        }
        public static void SwapMethod<T>(List<T> list, int index1, int index2)
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
