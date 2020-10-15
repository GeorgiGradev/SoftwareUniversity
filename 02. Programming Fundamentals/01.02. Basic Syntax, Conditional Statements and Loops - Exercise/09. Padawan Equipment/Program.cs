using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabers = (Math.Ceiling(students * 1.1) * lightsaberPrice);
            double robes = students * robesPrice;
            double belts = (students - (Math.Floor((double)students / 6))) * beltsPrice;

            double totalPrice = robes + lightsabers + belts;
            double diff = Math.Abs(budget - totalPrice);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {diff:f2}lv more.");
            }
        }
    }
}
