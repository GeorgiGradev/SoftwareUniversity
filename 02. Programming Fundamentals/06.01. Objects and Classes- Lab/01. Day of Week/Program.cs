using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(
                    Console.ReadLine(),
                     "dd-MM-yyyy",
                    CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
