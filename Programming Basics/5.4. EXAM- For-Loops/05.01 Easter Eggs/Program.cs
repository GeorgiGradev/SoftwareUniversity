using System;

namespace _05._01_Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string color = "";
            int countRed = 0;
            int countOrange = 0;
            int countBlue = 0;
            int countGreen = 0;

            for (int i = 0; i < n; i++)
            {
                color = Console.ReadLine();

                switch (color)
                {
                    case "red":
                        countRed += 1;
                        break;
                    case "orange":
                        countOrange += 1;
                        break;
                    case "blue":
                        countBlue += 1;
                        break;
                    case "green":
                        countGreen += 1;
                        break;
                }
            }

            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");
            if (countRed > countOrange && countRed > countBlue && countRed > countGreen)
            {
                Console.WriteLine($"Max eggs: {countRed} -> red");
            }
            else if (countOrange > countRed && countOrange > countBlue && countOrange > countGreen)
            {
                Console.WriteLine($"Max eggs: {countOrange} -> orange");
            }
            else if (countBlue > countRed && countBlue > countOrange && countBlue > countGreen)
            {
                Console.WriteLine($"Max eggs: {countBlue} -> blue");
            }
            else if (countGreen > countRed && countGreen > countOrange && countGreen > countBlue)
            {
                Console.WriteLine($"Max eggs: {countGreen} -> green");
            }
        }
    }
}
