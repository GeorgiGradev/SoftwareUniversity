using System;

namespace _06._01._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    count++;
                }
                else if (text[i] == 'e')
                {
                    count += 2;
                }
                else if (text[i] == 'i')
                {
                    count += 3;
                }
                else if (text[i] == 'o')
                {
                    count += 4;
                }
                else if (text[i] == 'e')
                {
                    count += 5;
                }
            }
            Console.WriteLine(count);
        }
    }
}
