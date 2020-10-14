using System;

namespace _08._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakes = int.Parse(Console.ReadLine());
            string winner = "";
            int bestGrade = -1;

            for (int i = 0; i < cakes; i++)
            {
                string name = Console.ReadLine();
                int sumGrades = 0;
                string gradeCommand = Console.ReadLine();

                while (gradeCommand != "Stop")
                {
                    sumGrades += int.Parse(gradeCommand);
                    gradeCommand = Console.ReadLine();

                }

                Console.WriteLine($"{name} has {sumGrades} points.");

                if (sumGrades > bestGrade)
                {
                    bestGrade = sumGrades;
                    winner = name;
                    Console.WriteLine($"{winner} is the new number 1!");
                }
            }
            Console.WriteLine($"{winner} won competition with {bestGrade} points!");
        }
    }
}
