using System;

namespace _05._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //boat in spring            = 3000 BGN
            //boat in sommer & autumn   = 4200 BGN
            //boat in winter            = 2600 BGN

            //fishers <= 6                 – discount 10 %
            //fishers > 7 && fishers <= 11 - discount 15 %
            //fishers > 12                 - discount 25 %

            //if fishers % 2 = 0 (not in Autumn) - discount 5 %

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case ("Spring"):
                    {
                        if (fishers <= 6)
                        {
                            price = 3000 * 0.9;
                        }
                        else if (fishers > 7 && fishers <= 11)
                        {
                            price = 3000 * 0.85;
                        }
                        else
                            price = 3000 * 0.75;
                        break;
                    }
                case ("Summer"):
                case ("Autumn"):
                    {
                        if (fishers <= 6)
                        {
                            price = 4200 * 0.9;
                        }
                        else if (fishers > 7 && fishers <= 11)
                        {
                            price = 4200 * 0.85;
                        }
                        else
                            price = 4200 * 0.75;
                        break;
                    }
                case ("Winter"):
                    {
                        if (fishers <= 6)
                        {
                            price = 2600 * 0.9;
                        }
                        else if (fishers > 7 && fishers <= 11)
                        {
                            price = 2600 * 0.85;
                        }
                        else
                            price = 2600 * 0.75;
                        break;
                    }
            }

            if (fishers % 2 == 0)
            {
                if (season != "Autumn")
                {
                    price *= 0.95;
                }
            }

            double difference = Math.Abs(budget - price);
            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        

        }
    }
}
