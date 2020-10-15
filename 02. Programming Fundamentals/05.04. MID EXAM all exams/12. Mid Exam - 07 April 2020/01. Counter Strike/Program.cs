using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int counter = 0;
            int wonBattles = 0;
            while (command != "End of battle")
            {
                counter++;
                int distance = int.Parse(command);

                if (counter % 3 != 0 && energy - distance >= 0)
                {
                    energy -= distance;
                    wonBattles++;
                }
                else if ((counter % 3 == 0 && (energy - distance) + wonBattles >= 0))
                {
                    wonBattles++;
                    energy = (energy - distance) + wonBattles;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {energy} energy");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {wonBattles}. Energy left: {energy}");
        }
    }
}
