using System;

namespace _05._10._Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());
            int countW = 0;
            int countD = 0;
            int countL = 0;

            for (int i = 0; i < games; i++)
            {
                char result = char.Parse(Console.ReadLine());
                
                if (result == 'W')
                {
                    countW++;
                }
                else if (result == 'D')
                {
                    countD++;
                }
                else if (result == 'L')
                {
                    countL++;
                }
            }
            int totalPoints = (countW * 3) + (countD * 1);

            if (games > 0)
            {
                Console.WriteLine($"{team} has won {totalPoints} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {countW}");
                Console.WriteLine($"## D: {countD}");
                Console.WriteLine($"## L: {countL}");
                Console.WriteLine($"Win rate: {(countW / (1.0 * games) * 100):f2}%");
            }
            else
            {
                Console.WriteLine($"{team} hasn't played any games during this season.");
            }

        }
    }
}
