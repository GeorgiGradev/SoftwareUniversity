using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int explosion = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    explosion += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (explosion > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    explosion--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
