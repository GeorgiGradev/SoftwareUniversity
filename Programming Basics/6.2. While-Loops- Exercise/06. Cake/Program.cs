using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int cakeVolume = width * lenght;
            int cakePieces = 0;

            while (cakePieces <= cakeVolume)
            {
                cakePieces = int.Parse(command);

                if (cakePieces < cakeVolume)
                {
                    cakeVolume -= cakePieces;
                }
                
                if (cakePieces > cakeVolume)
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces - cakeVolume} pieces more.");
                    break;
                }
                command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{cakeVolume} pieces are left.");
                }
            }
        }
    }
}
