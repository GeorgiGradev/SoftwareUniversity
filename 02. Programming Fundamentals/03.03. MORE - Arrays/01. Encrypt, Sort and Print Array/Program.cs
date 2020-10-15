using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfString = int.Parse(Console.ReadLine());

            int[] numbers = new int[numberOfString];
            string vowels = "aAeEiIoOuU";

            for (int i = 0; i < numberOfString; i++)
            {
                string input = Console.ReadLine();
                char[] letters = input.ToCharArray();

                int sum = 0;
                for (int k = 0; k < input.Length; k++)
                {
                    if (vowels.Contains(letters[k]))
                    {
                        sum += letters[k] * input.Length;
                    }
                    else
                    {
                        sum += letters[k] / input.Length;
                    }

                }
                numbers[i] = sum;
            }
            Array.Sort(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
