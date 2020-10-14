using System;

namespace _01._Pool_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            // един чадър стига за двама души. 
            // само 75 % от екипа искат шезлонги.
            // При изчислението на броя на чадърите и шезлонгите, да се закръгли до по-голямото цяло число.

            double people = double.Parse(Console.ReadLine());
            double fee = double.Parse(Console.ReadLine());
            double bedPrice = double.Parse(Console.ReadLine());
            double umbrellaPrice = double.Parse(Console.ReadLine());

            double entrancePrice = people * fee * 1.0;
            double umbrellaNumber = people / 2 * 1.0;
            double bedNumber = people * 0.75;

            double umbrellaNumberTotal = Math.Ceiling(umbrellaNumber);
            double bedNumberTotal = Math.Ceiling(bedNumber);


            double total = entrancePrice + (umbrellaPrice * umbrellaNumberTotal) + (bedNumberTotal * bedPrice);
            Console.WriteLine($"{total:F2} lv.");



        
        }
    }
}
