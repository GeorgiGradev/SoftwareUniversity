using System;

namespace _01._Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstTimeHours = firstTime / 60.0;
            double secondTimeHours = secondTime / 60.0;
            double thirdTimeHours = thirdTime / 60.0;

            double distance1 = startingSpeed * firstTimeHours;
            double distance2 = (startingSpeed * 1.1) * secondTimeHours;
            double distance3 = ((startingSpeed * 1.1) * 0.95) * thirdTimeHours;


            Console.WriteLine($"{distance1 + distance2 + distance3:f2}");
        }
    }
}
