using System;

namespace _06._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char let1 = char.Parse(Console.ReadLine());
            char let2 = char.Parse(Console.ReadLine());
            char let3 = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char x = let1; x <= let2; x++)
            {
                if (x == let3)
                {
                    continue;
                }
                for (char y = let1; y <= let2; y++)
                {
                    if (y == let3)
                    {
                        continue;
                    }
                    for (char z = let1; z <= let2; z++)
                    {
                        if (z == let3)
                        {
                            continue;
                        }
                        counter++;
                        Console.Write($"{x}{y}{z} ");
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
