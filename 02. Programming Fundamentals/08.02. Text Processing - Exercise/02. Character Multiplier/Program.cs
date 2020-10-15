using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            string word1 = input[0];
            string word2 = input[1];
            int sum = GetStringSum(word1, word2);

            Console.WriteLine(sum);
        }

        private static int GetStringSum(string word1, string word2)
        {
            int sum = 0;
            for (int i = 0; i < Math.Min(word1.Length, word2.Length); i++)
            {
                sum += word1[i] * word2[i];
            }
            if (word1.Length > word2.Length)
            {
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    sum += word1[i];
                }
            }
            else if (word2.Length > word1.Length)
            {
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    sum += word2[i];
                }
            }
            return sum;

        }
    }
}
   

