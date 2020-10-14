using System;

namespace _12._Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentCommand = Console.ReadLine();
            int counterWin = 0;
            int counterLost = 0;
            int counterGames = 0;

            while (tournamentCommand != "End of tournaments")
            {
                int games = int.Parse(Console.ReadLine());
                for (int i = 1; i <= games; i++)
                {
                    counterGames++;
                    int pointsTeam1 = int.Parse(Console.ReadLine());
                    int pointsTeam2 = int.Parse(Console.ReadLine());
                    int pointsDiff = Math.Abs(pointsTeam1 - pointsTeam2);

                    if (pointsTeam1 > pointsTeam2)
                    {
                        counterWin++;
                        Console.WriteLine($"Game {i} of tournament {tournamentCommand}: win with {pointsDiff} points.");
                    }
                    else
                    {
                        counterLost++;
                        Console.WriteLine($"Game {i} of tournament {tournamentCommand}: lost with {pointsDiff} points.");
                    }
                }
                tournamentCommand = Console.ReadLine();
            }
            Console.WriteLine($"{counterWin / (double)counterGames * 100:f2}% matches win");
            Console.WriteLine($"{counterLost / (double)counterGames * 100:f2}% matches lost");
        }
    }
}
