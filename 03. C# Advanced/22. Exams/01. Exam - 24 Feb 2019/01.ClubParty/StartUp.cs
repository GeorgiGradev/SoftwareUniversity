using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _01.ClubParty
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int capacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");

            Stack<string> elements = new Stack<string>(input);
            Queue<string> halls = new Queue<string>();
            List<int> groups = new List<int>();

            int currentCapacity = 0;

            while (elements.Any())
            {
                string currentElement = elements.Pop();

                bool isNumber = int.TryParse(currentElement, out int parsedNumber);
                if (!isNumber)  // буква
                {
                    halls.Enqueue(currentElement);
                }
                else  // число
                {
                    if (halls.Count == 0)
                    {
                        continue;
                    }

                    if (currentCapacity + parsedNumber > capacity)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", groups)}");
                        groups.Clear();
                        currentCapacity = 0;
                    }
                    if (halls.Any())
                    {
                        groups.Add(parsedNumber);
                        currentCapacity += parsedNumber;
                    }
                }
            }
        }
    }
}
