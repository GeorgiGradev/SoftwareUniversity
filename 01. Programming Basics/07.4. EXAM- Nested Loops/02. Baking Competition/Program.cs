using System;

namespace _02._Baking_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int participants = int.Parse(Console.ReadLine());

            double totalSum = 0;
            int totalPastries = 0;

            for (int i = 0; i < participants; i++)
            {
                string bakerName = Console.ReadLine();

                int cookiesCounter = 0;
                int cakesCounter = 0;
                int wafflesCounter = 0;

                string pastryCommand = Console.ReadLine();

                while (pastryCommand != "Stop baking!")
                {
                    int pastryNumber = int.Parse(Console.ReadLine());
                    switch (pastryCommand)
                    {
                        case "cookies":
                            cookiesCounter += pastryNumber;
                            break;
                        case "cakes":
                            cakesCounter += pastryNumber;
                            break;
                        case "waffles":
                            wafflesCounter += pastryNumber;
                            break;
                    }
                    pastryCommand = Console.ReadLine();
                }
                totalSum += ((cookiesCounter * 1.5) + (cakesCounter * 7.8) + (wafflesCounter * 2.3));
                totalPastries += (cookiesCounter + cakesCounter + wafflesCounter);
                Console.WriteLine($"{bakerName} baked {cookiesCounter} cookies, {cakesCounter} cakes and {wafflesCounter} waffles.");
            }
            Console.WriteLine($"All bakery sold: {totalPastries}");
            Console.WriteLine($"Total sum for charity: {totalSum:F2} lv.");
        }
    }
}
