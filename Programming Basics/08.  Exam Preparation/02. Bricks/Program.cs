using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int moves = 0;

            while (bricks > 0)
            {
                moves++;
                bricks -= (workers * capacity);
            }
            Console.WriteLine(moves);
        }
    }
}