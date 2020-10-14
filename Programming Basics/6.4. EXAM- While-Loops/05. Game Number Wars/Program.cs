using System;

namespace _05._Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string command1 = Console.ReadLine();
            string command2 = Console.ReadLine();

            int pointsPlayerOne = 0;
            int pointsPlayerTwo = 0;

            while (command1 != "End of game" && command2 != "End of game")
            {
                int cardPlayerOne = int.Parse(command1);
                int cardPlayerTwo = int.Parse(command2);
                if (cardPlayerOne > cardPlayerTwo)
                {
                    pointsPlayerOne += (cardPlayerOne - cardPlayerTwo);
                }
                else if (cardPlayerOne < cardPlayerTwo)
                {
                    pointsPlayerTwo += (cardPlayerTwo - cardPlayerOne);
                }
                else
                {   
                    command1 = Console.ReadLine();
                    command2 = Console.ReadLine();
                    cardPlayerOne = int.Parse(command1);
                    cardPlayerTwo = int.Parse(command2);
                    if (cardPlayerOne > cardPlayerTwo)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{nameOne} is winner with {pointsPlayerOne} points");
                        break;
                    }
                    else if (cardPlayerOne < cardPlayerTwo)
                    {
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{nameTwo} is winner with {pointsPlayerTwo} points");
                        break;
                    }
                }
                command1 = Console.ReadLine();
                command2 = Console.ReadLine();
            }
            if (command1 == "End of game" || command2 == "End of game")
            {
                Console.WriteLine($"{nameOne} has {pointsPlayerOne} points");
                Console.WriteLine($"{nameTwo} has {pointsPlayerTwo} points");
            }
        }
    }
}
