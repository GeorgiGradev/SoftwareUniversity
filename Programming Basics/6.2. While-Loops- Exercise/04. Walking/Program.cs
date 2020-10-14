using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int stepCounter = 0;

            while (command != "Going home")
            {
                int commandToNumber = int.Parse(command);
                stepCounter += commandToNumber;
                if (stepCounter >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    break;
                }

                command = Console.ReadLine();
            }
            if (command == "Going home")
            {
                command = Console.ReadLine();
                int commandToNumber1 = int.Parse(command);
                stepCounter += commandToNumber1;
                if (stepCounter < 10000)
                {
                    int diff = 10000 - stepCounter;
                    Console.WriteLine($"{diff} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine($"Goal reached! Good job!");
                }
            }
        }
    }
}
