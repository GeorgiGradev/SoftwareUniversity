using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int numberToRemove = 0;
            int listSum = 0;

            while (input.Count != 0)
            {
                int indexToRemove = int.Parse(Console.ReadLine());

                if (indexToRemove < 0)
                {
                    numberToRemove = input[0];  // to be used in the for loop!
                    listSum += numberToRemove;

                    input.RemoveAt(0); // remove the first element of the sequence
                    input.Insert(0, input[input.Count - 1]);  // copy the last element to its place.

                    IncreaseAndDecrease(input, numberToRemove);
                }
                else if (indexToRemove > input.Count - 1)
                {
                    numberToRemove = input[input.Count-1];  // to be used in the for loop!
                    listSum += numberToRemove;

                    input.RemoveAt(input.Count - 1); // remove the last element from the sequence
                    input.Add(input[0]); // copy the first element to its place

                    IncreaseAndDecrease(input, numberToRemove);
                }
                else // index to remove in range
                {
                    numberToRemove = input[indexToRemove];
                    listSum += numberToRemove;
                    input.RemoveAt(indexToRemove); // remove the element at that index from the sequence
                    IncreaseAndDecrease(input, numberToRemove);
                }
            }
            // print the summed value of all removed elements.
            Console.WriteLine(listSum);
        }

        private static List<int> IncreaseAndDecrease(List<int> input, int numberToRemove)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= numberToRemove)
                {
                    input[i] += numberToRemove;
                }
                else if (input[i] > numberToRemove)
                {
                    input[i] -= numberToRemove;
                }
            }
            return input;
        }
    }
}
