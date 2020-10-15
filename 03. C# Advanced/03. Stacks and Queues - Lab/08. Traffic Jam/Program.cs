using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace _08._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            int count = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string car = input;
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Any())
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(car);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}                                       
