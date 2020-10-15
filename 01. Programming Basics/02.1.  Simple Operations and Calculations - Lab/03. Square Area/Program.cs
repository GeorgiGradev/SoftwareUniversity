using System;

namespace _03._Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише конзолна програма, която въвежда цяло число 'a' и пресмята лицето на квадрат със страна 'a'. 
            int a = int.Parse(Console.ReadLine());

            int square = a * a;
            Console.WriteLine(square);

        }
    }
}
