using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Orders(type, quantity);
        }

        static void Orders(string type, int quantity)
        {
            double result = 0;
            if (type == "coffee")
            {
                result = quantity * 1.50;
            }
            else if (type == "water")
            {
                result = quantity * 1;
            }
            else if (type == "coke")
            {
                result = quantity * 1.40;
            }
            else if (type == "snacks")
            {
                result = quantity * 2;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
