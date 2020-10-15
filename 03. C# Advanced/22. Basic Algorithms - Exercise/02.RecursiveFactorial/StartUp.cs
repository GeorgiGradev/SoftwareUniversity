using System;
using System.Security.Cryptography.X509Certificates;

namespace _02.RecursiveFactorial
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Factoriel(input));
        }

        public static int Factoriel(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n * Factoriel(n - 1);
        }
    }
}
