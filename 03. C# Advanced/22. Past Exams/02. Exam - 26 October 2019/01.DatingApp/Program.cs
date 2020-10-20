using System;
using System.Collections.Generic;
using System.Linq;

namespace REDO_1.DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> females = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int matches = 0;

            while (males.Any() && females.Any())
            {
                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (females.Peek() % 25 == 0)
                {
                    females.Dequeue();
                    if (females.Any())
                    {
                        females.Dequeue();
                    }
                    continue;
                }

                if (males.Peek() % 25 == 0)
                {
                    males.Pop();
                    if (males.Any())
                    {
                        males.Pop();
                    }
                    continue;
                }

                if (males.Peek() == females.Peek())
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else if (males.Peek() != females.Peek())
                {
                    males.Push(males.Pop() - 2);
                    females.Dequeue();
                }
            }
            Console.WriteLine($"Matches: {matches}");
            string maleString = males.Count > 0 ? string.Join(", ", males) : "none";
            Console.WriteLine($"Males left: {maleString}");
            string femaleString = females.Count > 0 ? string.Join(", ", females) : "none";
            Console.WriteLine($"Females left: {femaleString}");
        }
    }
}
 