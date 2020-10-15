using System;

namespace _01._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegiMenu = int.Parse(Console.ReadLine());

            double totalMenus = (chickenMenu * 10.35) + (fishMenu * 12.40) + (vegiMenu * 8.15);
            double dessert = totalMenus * 0.2;
            double delivery = 2.5;

            double total = totalMenus + dessert + delivery;

            Console.WriteLine($"Total: {total:F2}");



        }
    }
}
