using System;

namespace _03_Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int points = 0;
            int counterLetters = 0;
            int counterNames = 0;
            int player1points = 0;
            int player2points = 0;
            string player1name = "";
            string player2name = "";

            while (name != "Stop")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number == name[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                    counterLetters++;
                    if (counterLetters == name.Length)
                    {
                        counterNames++;
                        if (counterNames == 1)
                        {
                            player1points = points;
                            player1name = name;
                        }
                        else
                        {
                            player2points = points;
                            player2name = name;
                        }
                        points = 0;
                        counterLetters = 0;
                        name = Console.ReadLine();
                        break;
                    }
                }
            }   
            if (player1points > player2points)
            {
                Console.WriteLine($"The winner is {player1name} with {player1points} points!");
            }
            else if (player1points <= player2points)
            {
                Console.WriteLine($"The winner is {player2name} with {player2points} points!");
            }
        }
    }
}

