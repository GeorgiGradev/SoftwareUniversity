using System;

namespace _09._Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            if (text == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (text != "sunny")
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}




