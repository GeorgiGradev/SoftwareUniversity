using System;

namespace _04._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowerType)
            {
                case "Roses":
                    {
                        if (flowerQuantity > 80)
                        {
                            price = 5 * 0.90;
                        }
                        else
                            price = 5;
                        break;
                    }
                case "Dahlias":
                    {
                        if (flowerQuantity > 90)
                        {
                            price = 3.8 * 0.85;
                        }
                        else
                            price = 3.8;
                        break;
                    }
                case "Tulips":
                    {
                        if (flowerQuantity > 80)
                        {
                            price = 2.8 * 0.85;
                        }
                        else
                            price = 2.8;
                        break;
                    }
                case "Narcissus":
                    {
                        if (flowerQuantity < 120)
                        {
                            price = 3 * 1.15;
                        }
                        else
                            price = 3;
                        break;
                    }
                case "Gladiolus":
                    {
                        if (flowerQuantity < 80)
                        {
                            price = 2.50 * 1.20;
                        }
                        else
                            price = 2.50;
                        break;
                    }
            }
            double total = flowerQuantity * price;
            double difference = Math.Abs(total - budget);

            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flowerType} and {difference:F2} leva left.");
            }
            else
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
        }
    }
}
