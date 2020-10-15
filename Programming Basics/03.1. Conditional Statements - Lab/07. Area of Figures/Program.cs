using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string fugure = Console.ReadLine();


            if (fugure == "square")
            {
                double ar = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ar * ar:F3}");
            }
            else if (fugure == "rectangle")
            {
                double ar = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ar * b:F3}");
            }
            else if (fugure == "circle")
            {
                double ar = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * ar * ar:F3}");
            }
            else if (fugure == "triangle")
            {
                double ar = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{ar * b / 2:F3}");
            }
        }
    }
}
