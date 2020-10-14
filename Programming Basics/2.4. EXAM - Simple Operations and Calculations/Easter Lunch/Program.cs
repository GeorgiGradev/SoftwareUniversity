using System;

namespace _01._Easter_Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterCake = int.Parse(Console.ReadLine());
            int eggsBox = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            int egg = eggsBox * 12;
            double total = (easterCake * 3.2) + (eggsBox * 4.35) + (egg * 0.15) + (cookies * 5.4);

            Console.WriteLine($"{total:F2}");

        }
    }
}
