using System;

namespace _01._Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statues = rent * 0.7;
            double catering = statues * 0.85;
            double sound = catering * 0.5;

            double total = rent + statues + catering + sound;

            Console.WriteLine($"{total:F2}");
        }   
    }
}
