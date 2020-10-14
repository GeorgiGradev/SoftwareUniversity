using System;

namespace _06._01._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int cakeVolume = width * lenght;
            int pieces = 0;

            while (input != "STOP")
            {
                pieces = int.Parse(input);
                if (cakeVolume >= pieces)
                {
                    cakeVolume -= pieces;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {pieces - cakeVolume} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
                if (input == "STOP")
            {
                Console.WriteLine($"{cakeVolume} pieces are left.");
            }
                
        }
    }
}
