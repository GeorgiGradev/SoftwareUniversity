using System;

namespace _03._11._Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            double diff = 0;
            double perf = 0;

            if (country == "Russia")
            {
                if (instrument == "ribbon")
                {
                    diff = 9.1;
                    perf = 9.4;
                }
                else if (instrument == "hoop")
                {
                    diff = 9.3;
                    perf = 9.8;
                }
                else if (instrument == "rope")
                {
                    diff = 9.6;
                    perf = 9;
                }
            }
            else if (country == "Bulgaria")
            {
                if (instrument == "ribbon")
                {
                    diff = 9.6;
                    perf = 9.4;
                }
                else if (instrument == "hoop")
                {
                    diff = 9.55;
                    perf = 9.75;
                }
                else if (instrument == "rope")
                {
                    diff = 9.5;
                    perf = 9.4;
                }
            }
            else if (country == "Italy")
            {
                if (instrument == "ribbon")
                {
                    diff = 9.2;
                    perf = 9.5;
                }
                else if (instrument == "hoop")
                {
                    diff = 9.45;
                    perf = 9.35;
                }
                else if (instrument == "rope")
                {
                    diff = 9.7;
                    perf = 9.15;
                }
            }

            double grade = diff + perf;
            double missing = (20 - grade) / 20 * 100;

            Console.WriteLine($"The team of {country} get {grade:F3} on {instrument}.");
            Console.WriteLine($"{missing:F2}%");
        }
    }
}
