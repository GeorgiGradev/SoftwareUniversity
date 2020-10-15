using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int prevCapacity = 0; 

            for (int i = 0; i < n; i++)
            {
                prevCapacity = capacity;
                int quantities = int.Parse(Console.ReadLine());
                capacity -= quantities;
                if (capacity < 0)
                {
                    capacity = prevCapacity;
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(255 - capacity);
        }
    }
}
