using System;

namespace _01._Giftbox_Coverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double size1side = double.Parse(Console.ReadLine());
            int sheets = int.Parse(Console.ReadLine());
            double cover1sheet = double.Parse(Console.ReadLine());

            double boxArea = size1side * size1side * 6;
            double coveredArea = 0;

            for (int i = 1; i <= sheets; i ++)
            {
                if (i % 3 != 0)
                {
                    coveredArea += cover1sheet;
                }
                else if (i % 3 == 0)
                {
                    coveredArea += cover1sheet * 0.25;
                }
            }

            double percentage = (coveredArea / boxArea) * 100;
            Console.WriteLine($"You can cover {percentage:f2}% of the box.");

        }
    }
}
