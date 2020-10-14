using System;

namespace _03._Nested_Conditional_Statesments
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            if (gender == 'm')
            {
                if (sport == "Gym")
                {
                    price = 42;
                }
                else if (sport == "Boxing")
                {
                    price = 41;
                }
                else if (sport == "Yoga")
                {
                    price = 45;
                }
                else if (sport == "Zumba")
                {
                    price = 34;
                }
                else if (sport == "Dances")
                {
                    price = 51;
                }
                else if (sport == "Pilates")
                {
                    price = 39;
                }
            }
            else if (gender == 'f')
            {
                if (sport == "Gym")
                {
                    price = 35;
                }
                else if (sport == "Boxing")
                {
                    price = 37;
                }
                else if (sport == "Yoga")
                {
                    price = 42;
                }
                else if (sport == "Zumba")
                {
                    price = 31;
                }
                else if (sport == "Dances")
                {
                    price = 53;
                }
                else if (sport == "Pilates")
                {
                    price = 37;
                }
            }
            if (age <= 19)
            {
                totalPrice = price * 0.8;
            }
            else
            {
                totalPrice = price;
            }


            if (budget >= totalPrice)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                double diff = totalPrice - budget;
                Console.WriteLine($"You don't have enough money! You need ${diff:f2} more.");
            }

        }
    }
}
