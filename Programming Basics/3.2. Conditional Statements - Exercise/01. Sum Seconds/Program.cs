using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());

            int sum = one + two + three;
            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");


        }
    }
}
