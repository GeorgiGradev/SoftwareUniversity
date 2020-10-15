using System;
using System.Collections.Generic;


namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "Paid" && input != "End")
                {
                    queue.Enqueue(input);
                }
                else if (input == "Paid")
                {
                    int count = queue.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else if (input == "End")
                {
                    Console.WriteLine($"{queue.Count} people remaining.");
                    break;
                }
            }
        }
    }
}
