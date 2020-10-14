using System;

namespace _02._Conditional_Statements__if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeightAustronauts = double.Parse(Console.ReadLine());

            double totalVolume = width * height * lenght;
            double areaFor1 = 2 * 2 * (averageHeightAustronauts + 0.4);

            double pax = Math.Floor(totalVolume / areaFor1);

            if (pax < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (pax > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {pax} astronauts.");
            }
        }
    }
}
