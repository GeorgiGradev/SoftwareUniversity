using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budgetGroup = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPricePerKm = double.Parse(Console.ReadLine());
            double foodExpensesPerPersonDay = double.Parse(Console.ReadLine());
            double roomPricePerPerson = double.Parse(Console.ReadLine());

            double currentExpenses = 0;

            if (people > 10)
            {
                roomPricePerPerson *= 0.75;
            }

            currentExpenses = ((people * foodExpensesPerPersonDay * days)
                    + (people * roomPricePerPerson * days));

            for (int i = 1; i <= days; i++)
            {

                double distance = double.Parse(Console.ReadLine());
                currentExpenses += fuelPricePerKm * distance;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    currentExpenses *= 1.4;
                }

                if (i % 7 == 0)
                {
                    currentExpenses -= (currentExpenses / people);
                }


                if (currentExpenses > budgetGroup)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpenses - budgetGroup):f2}$ more.");
                    break;
                }

            }
            if (budgetGroup >= currentExpenses)
            {
                Console.WriteLine($"You have reached the destination. You have {(budgetGroup - currentExpenses):f2}$ budget left.");
            }
        }
    }
}
