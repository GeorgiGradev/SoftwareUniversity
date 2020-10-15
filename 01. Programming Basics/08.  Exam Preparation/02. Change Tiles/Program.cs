using System;

namespace _02._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double priceFor1tile = double.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());

            double floorArea = floorLenght * floorWidth;
            double tileArea = (triangleSide * triangleHeight) / 2;
            double tilesNeeded = Math.Ceiling(floorArea / tileArea) + 5;

            double totalPrice = (tilesNeeded * priceFor1tile) + costs;
            double diff = Math.Abs(budget - totalPrice);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"{diff:f2} lv left.");

            }
            else
            {
                Console.WriteLine($"You'll need {diff:f2} lv more.");
            }
        }
    }
}
