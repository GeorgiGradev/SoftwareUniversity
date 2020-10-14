using System;

namespace _05._09._PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int i = 0; i < n; i++)
            {
                string game = Console.ReadLine();

                if (game == "Hearthstone")
                {
                    count1++;
                }
                else if (game == "Fornite")
                {
                    count2++;
                }
                else if (game == "Overwatch")
                {
                    count3++;
                }
                else
                {
                    count4++;
                }
            }

            int totalCount = count1 + count2 + count3 + count4;

            Console.WriteLine($"Hearthstone - {count1 / (1.0 * totalCount) * 100:f2}%");
            Console.WriteLine($"Fornite - {count2 / (1.0 * totalCount) * 100:f2}%");
            Console.WriteLine($"Overwatch - {count3 / (1.0 * totalCount) * 100:f2}%");
            Console.WriteLine($"Others - {count4 / (1.0 * totalCount) * 100:f2}%");
        }
    }
}
