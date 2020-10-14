using System;

namespace _02._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmShow = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double seats = rows * columns;

            switch (filmShow)
            {
                case "Premiere":
                    {
                        Console.WriteLine($"{seats * 12.00:F2} leva");
                    }
                    break;
                case "Normal":
                    {
                        Console.WriteLine($"{seats * 7.50:F2} leva");
                    }
                    break;
                case "Discount":
                    {
                        Console.WriteLine($"{seats * 5.00:F2} leva");
                    }
                    break;
            }
        }
    }
}
