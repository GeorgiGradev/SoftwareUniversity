using System;
using System.Linq;
namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();

            while (inputCommand != "END")
            {
                char[] trasform = inputCommand.ToCharArray();
                int[] inputArray = new int[inputCommand.Length];
                int[] outputArray = new int[inputArray.Length];

                for (int i = 0; i < trasform.Length; i++)
                {
                    inputArray[i] = (char)trasform[i];
                }
    
                for (int i = 0; i < inputArray.Length; i++)
                {
                    outputArray[i] = inputArray[inputArray.Length - i - 1];
                }

                if (inputArray.SequenceEqual(outputArray))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }


                inputCommand = Console.ReadLine();
            }
        }
    }
}
