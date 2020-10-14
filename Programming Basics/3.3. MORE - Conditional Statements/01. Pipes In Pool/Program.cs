using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

           double total = ((P1 + P2) * hours);
            double P1total = total - (P2 * hours);
            double P2total = total - (P1 * hours);

            if (total <= V)
            {
                Console.WriteLine($"The pool is {total / V * 100:F2}% full. Pipe 1: {P1total / total * 100:F2}%. Pipe 2: {P2total / total * 100:F2}%.");                   
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {total - V} liters.");
            }



        }
    }
}
