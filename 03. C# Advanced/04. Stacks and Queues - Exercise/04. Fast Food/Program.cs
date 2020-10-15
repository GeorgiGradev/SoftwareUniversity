using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(ordersInput);

            while (true)
            {
                if (queue.Peek() <= quantity)
                {
                    quantity -= queue.Dequeue();
                    if (queue.Count == 0)
                    {
                        Console.WriteLine(ordersInput.Max());
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else if (queue.Peek() > quantity)
                {
                    Console.WriteLine(ordersInput.Max());
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;
                }
            }
        }
    }
}
