using System;
using System.Collections.Generic;


namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);
            int counter = 1;

            while (queue.Count > 1)
            {
                string firstToLast = queue.Dequeue();
                if (counter == count)
                {
                    Console.WriteLine($"Removed {firstToLast}");
                    counter = 1;
                }
                else
                {
                    queue.Enqueue(firstToLast);
                    counter++;
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
