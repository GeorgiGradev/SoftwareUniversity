using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace _03.TheKitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> knives = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> forks = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            List<int> setList = new List<int>();

            while (knives.Any() && forks.Any())
            {
                int currentKnive = knives.Peek();
                int currentFork = forks.Peek();

                if (currentKnive > currentFork)
                {
                    setList.Add(knives.Pop() + forks.Dequeue());
                }
                else if (currentKnive < currentFork)
                {
                    knives.Pop();
                }
                else if (currentKnive == currentFork)
                {
                    forks.Dequeue();
                    knives.Push(knives.Pop() + 1);
                }
            }
            Console.WriteLine($"The bigger set is: {setList.Max()}");
            Console.WriteLine(string.Join(" ", setList));
        }
    }
}
