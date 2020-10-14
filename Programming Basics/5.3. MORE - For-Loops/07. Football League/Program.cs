using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            double totalFans = int.Parse(Console.ReadLine());
            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 0; i < totalFans; i++)
            {
                char sector = char.Parse(Console.ReadLine());
                if (sector == 'A')
                {
                    countA += 1;
                }
                else if (sector == 'B')
                {
                    countB += 1;
                }
                else if (sector == 'V')
                {
                    countV += 1;
                }
                else if (sector == 'G')
                {
                    countG += 1;
                }
            }
            double sectorA = countA / totalFans * 100;
            double sectorB = countB / totalFans * 100;
            double sectorV = countV / totalFans * 100;
            double sectorG = countG / totalFans * 100;
            double total = totalFans / stadiumCapacity * 100;

            Console.WriteLine($"{sectorA:f2}%");
            Console.WriteLine($"{sectorB:f2}%");
            Console.WriteLine($"{sectorV:f2}%");
            Console.WriteLine($"{sectorG:f2}%");
            Console.WriteLine($"{total:f2}%");
        }
    }
}
