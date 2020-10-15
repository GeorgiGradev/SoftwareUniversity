using System;
using System.Linq;
namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] input2 = Console.ReadLine()
               .Split()
               .ToArray();
            string result = string.Empty;

            for (int i = 0; i < input2.Length; i++)
            {
                for (int k = 0; k < input1.Length; k++)
                {
                    if (input1[k] == input2[i])
                    {
                        result += input2[i] + " ";
                    }
                }
            }
            Console.Write(result);
        }
    }
}
