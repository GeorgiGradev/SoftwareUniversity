using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stack<int> lillies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int storedFlowers = 0;

            const int flowersNeeded = 15;
            int wrethCount = 0;

            while (lillies.Any() && roses.Any())
            {
                if (lillies.Peek() + roses.Peek() == flowersNeeded)
                {
                    wrethCount++;
                    lillies.Pop(); roses.Dequeue();
                }
                else if (lillies.Peek() + roses.Peek() > flowersNeeded)
                {
                    lillies.Push(lillies.Pop() - 2);
                }
                else
                {
                    storedFlowers += lillies.Pop() + roses.Dequeue();
                }
            }
            wrethCount += storedFlowers / 15;
            
            if (wrethCount >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wrethCount} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wrethCount} wreaths more!");
            }
        }
    }
}
