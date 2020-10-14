using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double lenght = Math.Floor((h - 1) / 0.7);
            double widht = Math.Floor(w / 1.20);
         
            double all = (lenght * widht) - 3;
            Console.WriteLine(all);

        }
    }
}
