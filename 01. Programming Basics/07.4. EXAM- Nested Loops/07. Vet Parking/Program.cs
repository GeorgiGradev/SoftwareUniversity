using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;
            double totalSum = 0;

            for (int a = 1; a <= days; a++)
            {
                counter++;
                for (int b = 1; b <= hours; b++)
                {
                    if (a % 2 == 0 && b % 2 != 0)
                    {
                        sum1 += 2.5;
                    }
                    else if (a % 2 != 0 && b % 2 == 0)
                    {
                        sum2 += 1.25;
                    }
                    else
                    {
                        sum3 += 1;
                    }
                }

                Console.WriteLine($"Day: {counter} - {sum1 + sum2 + sum3:f2} leva");
                totalSum = totalSum + (sum1 + sum2 + sum3);
                sum1 = 0;
                sum2 = 0;
                sum3 = 0;
            }
            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
