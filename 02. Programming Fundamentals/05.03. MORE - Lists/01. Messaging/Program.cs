using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string message = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                int sum = 0;
                while (currentNumber > 0) // взимаме сумат на блоковете
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                int countIndexToFind = 0;
                for (int k = 0; k < sum; k++) // взимаме и добавяме буквата
                {
                    countIndexToFind++;
                    if (countIndexToFind == message.Length)
                    {
                        countIndexToFind = 0;
                    }
                }
                output += message[countIndexToFind].ToString(); // тук събираме намерените букви

                int countIndexToRemove = 0;
                for (int l = 0; l < sum; l++) // намираме и махаме взетата буква
                {
                    countIndexToRemove++;
                    if (countIndexToRemove == message.Length)
                    {
                        countIndexToRemove = 0;
                    }
                }
                message = message.Remove(countIndexToRemove, 1);
            }
            Console.WriteLine(output);
        }
    }
}
