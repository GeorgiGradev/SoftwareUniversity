using System;

namespace _05._Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());

            double roomArea = (lenght * 100) * (width * 100);
            double wardrobeArea = (wardrobeSide * 100) * (wardrobeSide * 100);
            double bench = roomArea / 10;
            double danceArea = roomArea - wardrobeArea - bench;
            double dancers = (danceArea / (7000 + 40));
            Console.WriteLine(Math.Floor(dancers));
        }
    }
}
