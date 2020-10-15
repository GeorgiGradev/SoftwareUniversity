using System;

namespace _05._12._Cruise_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int gamesCount = int.Parse(Console.ReadLine());
            double points = 0;
            double totalPoints = 0;
            double volleyballPoints = 0;
            double tennisPoints = 0;
            double badmintonPoints = 0;
            int volleyballCount = 0;
            int tennisCount = 0;
            int badmintonCount = 0;


            for (int i = 0; i < gamesCount; i++)
            {
                string gamesName = Console.ReadLine();
                points = int.Parse(Console.ReadLine());


                switch (gamesName)
                {
                    case "volleyball":
                        {
                            volleyballPoints = volleyballPoints + (points * 1.07);
                            volleyballCount++;
                            break;
                        }
                    case "tennis":
                        {
                            tennisPoints = tennisPoints + (points * 1.05);
                            tennisCount++;
                            break;
                        }
                    case "badminton":
                        {
                            badmintonPoints = badmintonPoints + (points * 1.02);
                            badmintonCount++;
                            break;
                        }
                }

            }
            totalPoints = volleyballPoints + tennisPoints + badmintonPoints;

            if ((volleyballPoints / volleyballCount) >= 75 & (tennisPoints / tennisCount) >= 75 && (badmintonPoints / badmintonCount) >= 75)
            {
                Console.WriteLine($"Congratulations, {player}! You won the cruise games with {Math.Floor(totalPoints)} points.");
            }
            else
            {
                Console.WriteLine($"Sorry, {player}, you lost. Your points are only {Math.Floor(totalPoints)}.");
            }
        }
    }
}
