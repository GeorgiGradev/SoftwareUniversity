using System;

namespace _05._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieCommand = Console.ReadLine();
            int counter = 0;
            string bestMovie = "";
            int points = 0;
            int bestPoints = 0;


            while (movieCommand != "STOP")
            {
                counter++;
                points = 0;
                for (int i = 0; i < movieCommand.Length; i++)
                {
                    char currentLetter = movieCommand[i];
                    if (currentLetter >= 97 && currentLetter <= 122)
                    {
                        points += (currentLetter - (2 * movieCommand.Length));
                    }
                    else if (currentLetter >= 65 && currentLetter <= 90)
                    {
                        points += (currentLetter - movieCommand.Length);
                    }
                    else
                    {
                        points += movieCommand[i];
                    }
 
                    if (points > bestPoints)
                    {
                        bestPoints = points;
                        bestMovie = movieCommand;
                    }
                }
                
                if (counter == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    break;
                }
                
                movieCommand = Console.ReadLine();
            }
            Console.WriteLine($"The best movie for you is {bestMovie} with {bestPoints} ASCII sum.");
        }
    }
}
