using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            int numberToAdd = nsx[0];
            int numberToRemove = nsx[1];
            int numberToFind = nsx[2];

            for (int i = 0; i < numberToAdd && input.Length > i ; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < numberToRemove ; i++)
            {
                if (queue.Any())
                {
                    queue.Dequeue();
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }

        }
    }
}
