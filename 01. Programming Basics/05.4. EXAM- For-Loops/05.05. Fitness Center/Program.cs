using System;

namespace _05._05._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countBack = 0;
            int countChest = 0;
            int countLegs = 0;
            int countAbs = 0;
            int countProteinShake = 0;
            int countProteinBar = 0;
            double countWorkout = 0;
            double countProtein = 0;

            for (int i = 0; i < n; i++)
            {
                string kindOfAction = Console.ReadLine();

                switch (kindOfAction)
                {
                    case "Back":
                        {
                            countBack++;
                            break;
                        }
                    case "Chest":
                        {
                            countChest++;
                            break;
                        }
                    case "Legs":
                        {
                            countLegs++;
                            break;
                        }
                    case "Abs":
                        {
                            countAbs++;
                            break;
                        }
                    case "Protein shake":
                        {
                            countProteinShake++;
                            break;
                        }
                    case "Protein bar":
                        {
                            countProteinBar++;
                            break;
                        }
                }
            }
            countWorkout = (countBack + countChest + countLegs + countAbs) / (1.0 * n) * 100;
            countProtein = (countProteinShake + countProteinBar) / (1.0 * n) * 100;

            Console.WriteLine($"{countBack} - back");
            Console.WriteLine($"{countChest} - chest");
            Console.WriteLine($"{countLegs} - legs");
            Console.WriteLine($"{countAbs} - abs");
            Console.WriteLine($"{countProteinShake} - protein shake");
            Console.WriteLine($"{countProteinBar} - protein bar");
            Console.WriteLine($"{countWorkout:f2}% - work out");
            Console.WriteLine($"{countProtein:f2}% - protein");
        }
    }
}
