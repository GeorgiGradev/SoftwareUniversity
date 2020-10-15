using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                var randomIndex = random.Next(0, input.Count);

                var randomEl = input[randomIndex];
                var el = input[i];

                input[randomIndex] = el;
                input[i] = randomEl;
            }
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}
