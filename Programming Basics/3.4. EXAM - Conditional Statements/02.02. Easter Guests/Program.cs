using System;

namespace _02._02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            //Един козунак струва 4лв.
            //Едно яйце струва 0.45лв

            // 1 cake -> 3 pax
            // 2 eggs -> 1 pax


            double pax = double.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cakes = Math.Ceiling(pax / 3);
            double eggs = pax * 2;

            double totalSpent = (cakes * 4) + (eggs * 0.45);

            if (budget >= totalSpent)
            {
                double leftOver = budget - totalSpent;
                Console.WriteLine($"Lyubo bought {cakes} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {leftOver:F2} lv. left.");
            }
            else
            {
                double needed = totalSpent - budget;
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {needed:F2} lv. more.");
            }
        }
    }
}
