using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                message += (char)(symbol + key);
            }
            Console.WriteLine(message);
        }
    }
}
