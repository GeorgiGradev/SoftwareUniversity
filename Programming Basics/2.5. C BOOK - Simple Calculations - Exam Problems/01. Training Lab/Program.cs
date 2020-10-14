using System;

namespace _01._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lenghtCM = lenght * 100;
            double widthCM = width * 100;

            int cols = (int)lenghtCM / 120;
            int rows = ((int)widthCM - 100) / 70;
            int seats = (cols * rows) - 3;
            Console.WriteLine(seats);


        }
    }
}
