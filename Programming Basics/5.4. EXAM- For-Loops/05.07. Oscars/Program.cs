using System;

namespace _05._07._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double begginingPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            bool breakTrue = true;

            double letterSum = 0;
            double newPoints = 0;
            double finalPoints = 0;
            double totalPoints = 0;

            for (int i = 0; i < n; i++)
            {
                string juri = Console.ReadLine();
                double juriPoints = double.Parse(Console.ReadLine());

                letterSum = juri.Length;

                newPoints = (letterSum * juriPoints) / 2;
                finalPoints += newPoints;

                if (finalPoints + begginingPoints >= 1250.5)
                {
                    breakTrue = true;
                    break;
                }

            }
            totalPoints = finalPoints + begginingPoints;
            double diff = Math.Abs(totalPoints - 1250.5);

            if (totalPoints > 1250.5 && breakTrue == true)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {(finalPoints + begginingPoints):f1}!");
            }
            else if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actor} you need {diff:f1} more!");
            }
        }
    } 
}
