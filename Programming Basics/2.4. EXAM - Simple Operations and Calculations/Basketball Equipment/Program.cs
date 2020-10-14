using System;

namespace _01._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // •Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка

            int annualTax = int.Parse(Console.ReadLine());

            double shoes = annualTax - (annualTax * 0.4);
            double clothes = shoes - (shoes * 0.2);
            double ball = clothes * 0.25;
            double accs = ball * 0.2;

            double total = annualTax + shoes + clothes + ball + accs;

            Console.WriteLine($"{total:F2}");

        }
    }
}
