using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int counterDays = 0;
            int workersConsumption = 26;
            int leftOver = 0;

            while (yield >= 100)
            {
                counterDays++;
                leftOver += yield - workersConsumption;
                yield -= 10;
            }
            leftOver -= workersConsumption;
            if (leftOver < 0)
            {
                leftOver = 0;
            }

            Console.WriteLine(counterDays);
            Console.WriteLine(leftOver);
        }
    }
}
