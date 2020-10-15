using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            int counter = 0;
            double totalExperience = 0;

            for (int i = 1; i <= battles; i++)
            {
                counter++;
                double earnedExperienceBattle = double.Parse(Console.ReadLine());
                if (i % 3 != 0 && i % 5 != 0)
                {
                    totalExperience += earnedExperienceBattle;
                }
                if (i % 3 == 0)
                {
                    totalExperience += earnedExperienceBattle * 1.15;
                }
                if (i % 5 == 0)
                {
                    totalExperience += earnedExperienceBattle * 0.9;
                }
                if (totalExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
                    break;
                }
            }

            if (neededExperience > totalExperience)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededExperience - totalExperience):f2} more needed.");
            }

        }
    }
}
