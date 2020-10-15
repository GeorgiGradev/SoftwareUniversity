using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int lv1 = int.Parse(Console.ReadLine());
            int lv2 = int.Parse(Console.ReadLine());
            int lv5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int a = 0; a <= lv1; a++)
            {
                for (int b = 0; b <= lv2; b++)
                {
                    for (int c = 0; c <= lv5; c++)
                    {
                        if ((a * 1) + (b * 2) + (c * 5) == sum)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {sum} lv.");
                            
                        }
                    }
                }
            }
        }
    }
}
