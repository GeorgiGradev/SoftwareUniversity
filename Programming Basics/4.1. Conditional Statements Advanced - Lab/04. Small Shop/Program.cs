using System;

namespace _04._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
         
            //град / продукт  coffee   water   beer   sweets  peanuts
            //Sofia            0.50    0.80    1.20    1.45    1.60
            //Plovdiv          0.40    0.70    1.15    1.30    1.50
            //Varna            0.45    0.70    1.10    1.35    1.55

            if (town == "Sofia")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(0.50 * quantity); break;
                    case "water": Console.WriteLine(0.80 * quantity); break;
                    case "beer": Console.WriteLine(1.20 * quantity); break;
                    case "sweets": Console.WriteLine(1.45 * quantity); break;
                    case "peanuts": Console.WriteLine(1.60 * quantity); break;
                }
            }
            else if (town == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(0.40 * quantity); break;
                    case "water": Console.WriteLine(0.70 * quantity); break;
                    case "beer": Console.WriteLine(1.15 * quantity); break;
                    case "sweets": Console.WriteLine(1.30 * quantity); break;
                    case "peanuts": Console.WriteLine(1.50 * quantity); break;
                }
            }
            else if (town == "Varna")
            {
                switch (product)
                {
                    case "coffee": Console.WriteLine(0.45 * quantity); break;
                    case "water": Console.WriteLine(0.70 * quantity); break;
                    case "beer": Console.WriteLine(1.10 * quantity); break;
                    case "sweets": Console.WriteLine(1.35 * quantity); break;
                    case "peanuts": Console.WriteLine(1.55 * quantity); break;
                }
            }
        }
    }
}
