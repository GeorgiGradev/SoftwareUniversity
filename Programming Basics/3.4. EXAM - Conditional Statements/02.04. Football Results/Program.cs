using System;

namespace _02._04._Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string game1 = Console.ReadLine();
            string game2 = Console.ReadLine();
            string game3 = Console.ReadLine();

            int countWins = 0;
            int countDraws = 0;
            int countLoses = 0;


            if (game1[0] > game1[2])
            {
                countWins++;
            }
            if (game2[0] > game2[2])
            {
                countWins++;
            }
            if (game3[0] > game3[2])
            {
                countWins++;
            }
            if (game1[0] == game1[2])
            {
                countDraws++;
            }
            if (game2[0] == game2[2])
            {
                countDraws++;
            }
            if (game3[0] == game3[2])
            {
                countDraws++;
            }
            if (game1[0] < game1[2])
            {
                countLoses++;
            }
            if (game2[0] < game2[2])
            {
                countLoses++;
            }
            if (game3[0] < game3[2])
            {
                countLoses++;
            }

            Console.WriteLine($"Team won {countWins} games.");
            Console.WriteLine($"Team lost {countLoses} games.");
            Console.WriteLine($"Drawn games: {countDraws}");

        }
    }
}


     //if (game1[0] < game1[2] || game2[0] < game2[2] || game3[0] < game3[2])