using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int oddRowCount = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char a = 'A'; a <= lastSector; a++)
            {
                if (a > 'A')
                {
                    rowsFirstSector++;
                }
                for (int b = 1; b <= rowsFirstSector; b++)
                {
                    if (b % 2 != 0)
                    {
                        for (char c = 'a'; c < 'a' + oddRowCount; c++)
                        {
                            Console.WriteLine($"{a}{b}{c}");
                            counter++;
                        }
                    }
                    else
                        for (char c = 'a'; c < 'a' + oddRowCount + 2; c++)
                        {
                            Console.WriteLine($"{a}{b}{c}");
                            counter++;
                        }
                    
                }
            }
            Console.WriteLine(counter);
        }
    }
}
