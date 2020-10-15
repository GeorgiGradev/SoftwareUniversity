using System;

namespace _03._Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int O = int.Parse(Console.ReadLine());

            double area = (N * N) - (M * O);
            double tileArea = W * L;

            double tiles = area / tileArea;
            double time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);



        }
    }
}