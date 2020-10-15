using System;

namespace _04._Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            if (A > B)
                Console.WriteLine(A);
            else
                Console.WriteLine(B);

        }
    }
}
