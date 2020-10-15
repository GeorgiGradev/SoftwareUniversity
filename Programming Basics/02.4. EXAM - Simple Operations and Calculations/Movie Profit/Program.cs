using System;

namespace _01._Movie_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Име на филм -текст
            //2.Брой дни - цяло число в диапазона[1… 90]
            //3.Брой билети - цяло число в диапазона[100… 100000]
            //4.Цена на билет -реално число в диапазона[5.0… 25.0]
            //5.Процент за киното -цяло число в диапазона[5... 35]

            string movie = (Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercent = int.Parse(Console.ReadLine());

            double total = days * tickets * ticketPrice;
            double cinema = total * cinemaPercent / 100;

            double profit = total - cinema;

            Console.WriteLine($"The profit from the movie {movie} is {profit:F2} lv.");



        }
    }
}
