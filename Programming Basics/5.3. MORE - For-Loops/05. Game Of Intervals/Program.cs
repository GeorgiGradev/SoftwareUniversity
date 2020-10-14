using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;


            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 0 && num <10)
                {
                    result = result + (num / 100 * 20);
                    count1 += 1;
                }
               else if (num >= 10 && num < 20)
                {
                    result = result + (num / 100 * 30);
                    count2 += 1;
                }
                else if (num >= 20 && num < 30)
                {
                    result = result + (num / 100 * 40);
                    count3 += 1;
                }
                else if (num >= 30 && num < 40)
                {
                    result = result + 50;
                    count4 += 1;
                }
                else if (num >= 40 && num <= 50)
                {
                    result = result + 100;
                    count5 += 1;
                }
                else
                {
                    result = result / 2;
                    count6 += 1;
                }
            }
            double totalCount = count1 + count2 + count3 + count4 + count5 + count6;
            double A1 = count1 * 1.0 / totalCount * 100;
            double A2 = count2 * 1.0 / totalCount * 100;
            double A3 = count3 * 1.0 / totalCount * 100;
            double A4 = count4 * 1.0 / totalCount * 100;
            double A5 = count5 * 1.0 / totalCount * 100;
            double A6 = count6 * 1.0 / totalCount * 100;


            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {A1:f2}%");
            Console.WriteLine($"From 10 to 19: {A2:f2}%");
            Console.WriteLine($"From 20 to 29: {A3:f2}%");
            Console.WriteLine($"From 30 to 39: {A4:f2}%");
            Console.WriteLine($"From 40 to 50: {A5:f2}%");
            Console.WriteLine($"Invalid numbers: {A6:f2}%");
        }
    }
}
