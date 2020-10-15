using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                output += char.Parse(Console.ReadLine());
            }
            Console.WriteLine(output);

        }
    }
}
