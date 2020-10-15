using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                for (int k = 0; k < n; k++)
                {
                    char seconfChar = (char)('a' + k);
                    for (int l = 0; l < n; l++)
                    {
                        char thirdChar = (char)('a' + l);
                        Console.WriteLine($"{firstChar}{seconfChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
