using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int n = 1;
            int counter = 0;

           while (counter < num)
            {
                counter++;
                Console.WriteLine(n);
                sum += n;
                n += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
