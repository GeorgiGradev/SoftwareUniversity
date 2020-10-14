using System;

namespace _02._05._Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ред 1.Минути на контролата – цяло число в интервала[0…59]
            //Ред 2.Секунди на контролата – цяло число в интервала[0…59]
            //Ред 3.Дължината на улея в метри – реално число в интервала[0.00…50000]
            //Ред 4.Секунди за изминаване на 100 метра – цяло число в интервала[0…1000]

            // на всеки 120 метра неговото време намаля с 2.5 секунди.

            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int secondFor100m = int.Parse(Console.ReadLine());

            int minutesInSeconds = minutes * 60;
            int totalControla = seconds + minutesInSeconds;

            double marinTimeSeconds = (lenght / 120) * ((secondFor100m * 1.2) - 2.5);  

            if (marinTimeSeconds <= totalControla)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {marinTimeSeconds:F3}.");
            }
            else
            {
                double difference = marinTimeSeconds - totalControla;
                Console.WriteLine($"No, Marin failed! He was {difference:F3} second slower.");
            }
        }
    }
}
