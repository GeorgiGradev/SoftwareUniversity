using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandStartInput = Console.ReadLine();
            double sum = 0;
            double previuosSum = 0;
            bool isValid = true;

            while (commandStartInput != "Start")
            {
                double input = double.Parse(commandStartInput);
                if (input == 0.1 || input == 0.2 || input == 0.5 || input == 1 || input == 2)
                {
                    sum += input;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                commandStartInput = Console.ReadLine();
            }

            string productCommand = Console.ReadLine();
            while (productCommand != "End")
            {
                previuosSum = sum;
                if (productCommand == "Nuts")
                {
                    sum -= 2;
                }
                else if (productCommand == "Water")
                {
                    sum -= 0.7;
                }
                else if (productCommand == "Crisps")
                {
                    sum -= 1.5;
                }
                else if (productCommand == "Soda")
                {
                    sum -= 0.8;
                }
                else if (productCommand == "Coke")
                {
                    sum -= 1;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                    isValid = false;
                }
                if (sum < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    sum = previuosSum;
                }
                else if (sum >= 0 && isValid)
                {
                    Console.WriteLine($"Purchased {productCommand.ToLower()}");
                }
                productCommand = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
