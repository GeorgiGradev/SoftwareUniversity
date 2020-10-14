using System;

namespace _01._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1eggs = int.Parse(Console.ReadLine());
            int player2eggs = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                if (command == "one")
                {
                    player2eggs--;
                }
                if (command == "two")
                {
                    player1eggs--;
                }
                if (player1eggs == 0 || player2eggs == 0)
                {
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {player1eggs} eggs left.");
                Console.WriteLine($"Player two has {player2eggs} eggs left.");
            }
            if (player1eggs == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {player2eggs} eggs left.");
            }
            if (player2eggs == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {player1eggs} eggs left.");
            }
        }
    }
}
