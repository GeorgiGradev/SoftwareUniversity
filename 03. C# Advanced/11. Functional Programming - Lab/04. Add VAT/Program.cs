using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, double> parser = n => double.Parse(n);

            //double[] input = Console.ReadLine()
            //    .Split(", ")
            //    .Select(parser)
            //    .Select(x => x * 1.2)
            //    .ToArray();

            //foreach (var item in input)
            //{
            //    Console.WriteLine($"{item:f2}");
            //}


            Func<double, double> VATadder = VATcalc;

            var input = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(VATadder);
            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }

        static double VATcalc(double price)
        {
            double result = price * 1.2;
            return result;
        }
    }
}
