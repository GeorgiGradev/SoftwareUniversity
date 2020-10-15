using System;

namespace _11._High_Jump
{
    class Program
    {
        static void Main(string[] args)
        {
            int goalHeight = int.Parse(Console.ReadLine());
            int startingHeight = goalHeight - 30;
            int attemptsCounter = 0;
            bool isFailed = false;

            while (startingHeight <= goalHeight)
            {
                for (int i = 1; i <= 3; i++)
                {
                    int jumpHeight = int.Parse(Console.ReadLine());
                    attemptsCounter++;
                    if (jumpHeight > startingHeight)
                    {
                        startingHeight += 5;
                        break;
                    }
                    if (i == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {startingHeight}cm after {attemptsCounter} jumps.");
                        isFailed = true;
                    }
                }
                if (true)
                {
                    break;
                }
            }
            if (!isFailed)
            {
                Console.WriteLine($"Tihomir succeeded, he jumped over {goalHeight}cm after {attemptsCounter} jumps.");
            }

        }
    }
}

