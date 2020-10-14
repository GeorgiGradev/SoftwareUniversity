using System;

namespace _02._07._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int shootingTime = int.Parse(Console.ReadLine());
            int sceneNumber = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double realShootingTime = shootingTime * 0.85;
            double realSceneTime = sceneTime * sceneNumber * 1.0;

            if (realShootingTime >= realSceneTime)
            {
                double difference = realShootingTime - realSceneTime;
                Console.WriteLine($"You managed to finish the movie on time! " +
                    $"You have {Math.Round(difference)} minutes left!");
            }
            else
            {
                double difference = realSceneTime - realShootingTime;
                Console.WriteLine($"Time is up! To complete the movie you need " +
                    $"{Math.Round(difference)} minutes.");
            }


        }
    }
}
