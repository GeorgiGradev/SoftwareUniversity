using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            // ВХОД
            // 1.Дължина в см – цяло число в интервала [10 … 500]
            // 2.Широчина в см – цяло число в интервала[10 … 300]
            // 3.Височина в см – цяло число в интервала[10… 200]
            // 4.Процент  – реално число в интервала[0.000 … 100.000]

            // ИЗХОД
            // •литрите, форматирани до третия знак 

            int lenghtCM = int.Parse(Console.ReadLine());
            int widthCM = int.Parse(Console.ReadLine());
            int heightCM = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenghtCM * widthCM * heightCM;
            double volumeLTR = volume * 0.001;
            double finalVolume = volumeLTR - (volumeLTR * percent * 0.01);
            
            Console.WriteLine($"{finalVolume:F3}");




        }
    }
}
