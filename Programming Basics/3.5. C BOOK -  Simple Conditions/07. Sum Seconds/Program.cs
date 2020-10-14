using System;

namespace _07._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int totalMinutes = (A + B + C) / 60;
            int totalSeconds = (A + B + C) % 60;

            Console.WriteLine($"{totalMinutes}:{totalSeconds:D2}");


        }

    }
}
