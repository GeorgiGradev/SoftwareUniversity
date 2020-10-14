using System;

namespace _12._Darts_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningPoints = int.Parse(Console.ReadLine());

            string sectors = "";
            int points = 0;
            int moveCounter = 0;

            while (beginningPoints > 0)
            {
                sectors = Console.ReadLine();
                moveCounter++;
                if (sectors == "bullseye")
                {
                    Console.WriteLine($"Congratulations! You won the game with a bullseye in {moveCounter} moves!");
                    break;
                }
                points = int.Parse(Console.ReadLine());
                if (sectors == "number section")
                {
                    beginningPoints -= points;
                }
                if (sectors == "double ring")
                {
                    beginningPoints -= (points * 2);
                }
                if (sectors == "triple ring")
                {
                    beginningPoints -= (points * 3);
                }

                
            }
            if (beginningPoints < 0)
            {
                Console.WriteLine($"Sorry, you lost. Score difference: {Math.Abs(beginningPoints)}.");
            }
            if (beginningPoints == 0)
            {
                Console.WriteLine($"Congratulations! You won the game in {moveCounter} moves!");
            }
        }
    }
}
