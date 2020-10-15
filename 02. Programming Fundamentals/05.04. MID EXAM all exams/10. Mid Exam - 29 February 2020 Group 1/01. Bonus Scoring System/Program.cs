using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double currentBonus = 0;
            int maxLectures = 0;

            for (int i = 0; i < students; i++)
            {
                currentBonus = 0; 
                int attendances = int.Parse(Console.ReadLine());

                currentBonus = attendances / (double)lectures * (5 + bonus);
                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxLectures = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}
