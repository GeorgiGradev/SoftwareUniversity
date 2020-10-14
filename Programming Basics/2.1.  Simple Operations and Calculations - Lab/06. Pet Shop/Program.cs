using System;

namespace _06._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //храна за кучета е на цена 2.50лв
            // която не е за тях струва 4лв.

            int dogs = int.Parse(Console.ReadLine());
            int pets = int.Parse(Console.ReadLine());

            double dogFood = dogs * 2.50;
            double petFood = pets * 4.0;

            double total = dogFood + petFood;


            Console.WriteLine($"{total:F2} " + "lv.");


        }
    }
}
