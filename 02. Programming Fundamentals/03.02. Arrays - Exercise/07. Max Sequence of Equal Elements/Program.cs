using System;
using System.Linq;
namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
            int counter = 0;
            int winningCounter = 0;
            string number = string.Empty;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;
                    if (counter > winningCounter) 
                    {
                        winningCounter = counter;
                        number = input[i].ToString();
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            if (winningCounter == 0)
            {
                Console.WriteLine(input[0]);
            }
            else
            {
                for (int i = 0; i <= winningCounter; i++)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}