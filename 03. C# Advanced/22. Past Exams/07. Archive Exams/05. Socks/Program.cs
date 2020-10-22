using System;
using System.Linq;
using System.Collections.Generic;

namespace Socks
{
    class Program
    {
        static void Main()
        {
            int[] inputLeftSocks = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] inputRightSocks = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            Stack<int> leftSocks = new Stack<int>(inputLeftSocks);
            Queue<int> rightSocks = new Queue<int>(inputRightSocks);

            List<int> pairs = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                int currentLeftSocks = leftSocks.Peek();
                int currentRighrSocks = rightSocks.Peek();

                if (currentLeftSocks > currentRighrSocks)
                {
                    pairs.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }

                if (currentRighrSocks > currentLeftSocks)
                {
                    leftSocks.Pop();

                    continue;
                }

                if (currentRighrSocks == currentLeftSocks)
                {
                    rightSocks.Dequeue();

                    leftSocks.Push(leftSocks.Pop() + 1);
                }
            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));
        }
    }
}