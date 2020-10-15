using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double dailyPlunder = double.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double plunder = 0;

            for (int i = 1; i <= days; i++)
            {

                plunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    plunder += dailyPlunder * 0.5;
                }
                if (i % 5 == 0)
                {
                    plunder -= plunder * 0.3;
                }
            }
            if (plunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {plunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {((plunder / expectedPlunder) * 100):f2}% of the plunder.");
            }
        }
    }
}
