using System;

namespace _01._Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine());
            double amountNeededMonth = double.Parse(Console.ReadLine());

            double unexpected = income * 0.3;
            double total = income - (unexpected + amountNeededMonth);

            double all = months * total;

            double percent = total / income * 100;

            Console.WriteLine($"She can save {percent:F2}%");
            Console.WriteLine($"{all:F2}");




        }
    }
}
