using System;

namespace _01._Series_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = (Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());
            int episods = int.Parse(Console.ReadLine());
            double lenght = Double.Parse(Console.ReadLine());

            double total = (seasons * episods * 1.2 * lenght) + (seasons * 10);
            Console.WriteLine($"Total time needed to watch the {movie} series is {Math.Floor(total)} minutes.");


        }
    }
}
