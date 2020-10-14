using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counterPrime = 0;
            int counterNonPrime = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                bool isPrime = true;
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                    for (int i = 2; i <= Math.Sqrt(number); i++)
                {

                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    counterPrime += number;
                }
                else
                {
                    counterNonPrime += number;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {counterPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {counterNonPrime}");
        }
    }
}

