using System;

namespace _10._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int appVolume = width * lenght * height;
            int packVolume = 0;

            while (command != "Done")
            {
                int commandAsNumber = int.Parse(command);
                packVolume += commandAsNumber;
                if (appVolume < packVolume)
                {
                    Console.WriteLine($"No more free space! You need {packVolume - appVolume} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();
            }
            if (appVolume > packVolume)
                Console.WriteLine($"{appVolume - packVolume} Cubic meters left.");
        }
    }
}
