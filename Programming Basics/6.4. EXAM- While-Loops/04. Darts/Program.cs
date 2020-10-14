using System;

namespace _04._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string shot = Console.ReadLine();

            int points = 0;
            int totalPoints = 0;
            int finalPoints = 0;
            int failCounter = 0;
            int successCounter = 0;

            while (totalPoints != 301 && shot != "Retire")
            {
                points = int.Parse(Console.ReadLine());
                finalPoints = totalPoints;
                if (shot == "Single")
                {
                    totalPoints += points;
                    successCounter++;
                }
                else if (shot == "Double")
                {
                    totalPoints += (points * 2);
                    successCounter++;
                }
                else if (shot == "Triple")
                {
                    totalPoints += (points * 3);
                    successCounter++;
                }

                if (totalPoints > 301)
                {
                    totalPoints = finalPoints;
                    failCounter++;
                    successCounter--;
                }
                shot = Console.ReadLine();
            }
            if (totalPoints == 301)
            {
                Console.WriteLine($"{playerName} won the leg with {successCounter} shots.");
            }
            if (shot == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {failCounter} unsuccessful shots.");
            }
        }
    }
}
