using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValueFirstPair = int.Parse(Console.ReadLine());
            int startValueSecondPair = int.Parse(Console.ReadLine());
            int differenceFirstPair = int.Parse(Console.ReadLine());
            int differenceSecondPair = int.Parse(Console.ReadLine());

            for (int a = startValueFirstPair; a <= startValueFirstPair + differenceFirstPair; a++)
            {
                for (int b = startValueSecondPair; b <= startValueSecondPair + differenceSecondPair; b++)
                {
                    bool isPrime1 = true;
                    for (int i = 2; i <= Math.Sqrt(a); i++)
                    {
                        if (a % i == 0)
                        {
                            isPrime1 = false;
                        }
                    }
                    bool isPrime2 = true;
                    for (int i = 2; i <= Math.Sqrt(b); i++)
                    {
                        if (b % i == 0)
                        {
                            isPrime2 = false;
                        }
                    }
                    if (isPrime1 && isPrime2)
                    {
                        Console.WriteLine($"{a}{b}");
                    }
                }
            }
        }
    }
}
