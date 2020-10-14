using System;

namespace _03._01._Luggage_Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int depth = int.Parse(Console.ReadLine());
            string ticket = Console.ReadLine();

            int tax = 0;
            double caseVolume = width * height * depth;



            if (caseVolume > 50 && caseVolume <= 100)
            {
                if (ticket == "true")
                {
                    tax = 0;

                }
                else if (ticket == "false")
                {
                    tax = 25;
                }
            }
            else if (caseVolume > 100 && caseVolume <= 200)
            {
                if (ticket == "true")
                {
                    tax = 10;

                }
                else if (ticket == "false")
                {
                    tax = 50;
                }
            }
            else if (caseVolume > 200 && caseVolume <= 300)
            {
                if (ticket == "true")
                {
                    tax = 20;
                }
                else if (ticket == "false")
                {
                    tax = 100;
                }
            }


            Console.WriteLine($"Luggage tax: {tax:F2}");

        }
    }
}
