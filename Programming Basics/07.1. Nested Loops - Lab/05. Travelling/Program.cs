using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinationCommand = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double income = double.Parse(Console.ReadLine());

            double totalIncome = 0;

            while (destinationCommand != "End")
            {
                while (totalIncome < budget)
                {
                    totalIncome += income;

                    if (totalIncome < budget)
                    {
                        income = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine($"Going to {destinationCommand}!");
                        totalIncome = 0;
                        income = 0;
                        break;
                    }
                }
                destinationCommand = Console.ReadLine();
                if (destinationCommand == "End")
                {
                    break;
                }
                budget = double.Parse(Console.ReadLine());
            }

        }
    }
}
