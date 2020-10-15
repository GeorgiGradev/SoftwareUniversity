using System;

namespace _07._Movie_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double salary = 0;

            while (command != "ACTION")
            {
                
                if (command.Length <= 15)
                {
                    salary = double.Parse(Console.ReadLine());
                    budget -= salary;
                }
                else
                {
                    salary = budget * 0.2;
                    budget -= salary;
                }
                if (budget < 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "ACTION" || budget >= 0)
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
