using System;

namespace _02._11._Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int reservationDay = int.Parse(Console.ReadLine());
            int reservationMonth = int.Parse(Console.ReadLine());
            int checkInDay = int.Parse(Console.ReadLine());
            int checkInMonth = int.Parse(Console.ReadLine());
            int checkOutDay = int.Parse(Console.ReadLine());
            int checkOutMonth = int.Parse(Console.ReadLine());

            double pricePerDay = 0.00;

            if (reservationMonth < checkInMonth)
            {
                pricePerDay = 25 * 0.80;
            }
            else if (reservationDay + 10 <= checkInDay)
            {
                pricePerDay = 25;
            }
            else
            {
                pricePerDay = 30;
            }

            double total = (checkOutDay - checkInDay) * pricePerDay * 1.00;

            Console.WriteLine($"Your stay from {checkInDay}/{checkInMonth} to {checkOutDay}/{checkOutMonth} will cost {total:F2}");



        }
    }
}
