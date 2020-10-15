using System;

namespace _01._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Предпазен найлон -1.50 лв.за кв.м.
            //Боя - 14.50 лв.за литър
            //Разредител за боя - 5.00 лв.за литър
            //+ 10 % от количеството боя 
            //+ 2 кв.м.найлон
            //+ 0.40 лв.за торбички
            //1 час работа, = 30 % от сбора на всички разходи за материали

            int naylon = int.Parse(Console.ReadLine());
            int paintLTR = int.Parse(Console.ReadLine());
            int diluentLTR = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double naylonPrice = naylon * 1.5;
            double paintPrice = paintLTR * 14.5;
            double diluentPrice = diluentLTR * 5;

            double naylonTotal = naylonPrice + (2 * 1.5);
            double paintTotal = paintPrice + (paintPrice * 0.1);

            double total = naylonTotal + paintTotal + diluentPrice + 0.4;

            double workersPrice = total * 0.3;

            double all = workersPrice * hours;

            double allTotal = all + total;

            Console.WriteLine($"Total expenses: {allTotal:F2} lv.");

        }
    }
}
