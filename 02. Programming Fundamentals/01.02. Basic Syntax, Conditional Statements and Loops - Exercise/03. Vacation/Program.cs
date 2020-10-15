 using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string kindOfPeople = Console.ReadLine();
            string day = Console.ReadLine();
            decimal price = 0;
            decimal totalPrice = 0;

            if (kindOfPeople == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45M;
                }
                else if (day == "Saturday")
                {
                    price = 9.80M;
                }
                else if (day == "Sunday")
                {
                    price = 10.46M;
                }
            }
            else if (kindOfPeople == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90M;
                }
                else if (day == "Saturday")
                {
                    price = 15.60M;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (kindOfPeople == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15M;
                }
                else if (day == "Saturday")
                {
                    price = 20M;
                }
                else if (day == "Sunday")
                {
                    price = 22.5M;
                }
            }

            totalPrice = price * people;

            if (kindOfPeople == "Students" && people >= 30)
            {
                totalPrice *= 0.85M;
            }
            if (kindOfPeople == "Business" && people >= 100)
            {
                totalPrice = price * (people - 10);
            }
            if (kindOfPeople == "Regular" && (people >= 10 && people <= 20))
            {
                totalPrice *= 0.95M;
            }
                Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
