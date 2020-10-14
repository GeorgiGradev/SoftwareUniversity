using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            double transport = 0;

            if (people < 5)
            {
                transport = budget * 0.75;
            }
            else if (people > 4 && people < 10)
            {
                transport = budget * 0.60;
            }
            else if (people > 9 && people < 25)
            {
                transport = budget * 0.50;
            }
            else if (people > 24 && people < 50)
            {
                transport = budget * 0.40;
            }
            else
            {
                transport = budget * 0.25;
            }

            double moneyLeft = budget - transport;
            double moneyFor1ticket = moneyLeft / people * 1.00;

            if (category == "VIP")
            {
                double difference = Math.Abs(moneyLeft - (people * 499.99));
                if (moneyFor1ticket >= 499.99)
                    Console.WriteLine($"Yes! You have {difference:F2} leva left.");
                else
                    Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
            if (category == "Normal")
            {
                double difference = Math.Abs(moneyLeft - (people * 249.99));
                if (moneyFor1ticket >= 249.99)
                    Console.WriteLine($"Yes! You have {difference:F2} leva left.");
                else
                    Console.WriteLine($"Not enough money! You need {difference:F2} leva.");
            }
        }
    }
}
