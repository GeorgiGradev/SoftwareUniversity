using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedLittersOfWater = 0;
            while (bottles.Count != 0 && cups.Count != 0)
            {
                if (bottles.Peek() >= cups.Peek()) // чашата е по-малка или равна на бутилката
                {
                    wastedLittersOfWater += (bottles.Pop() - cups.Dequeue());
                }
                else // чашата е по-голяма от бутилката и добавяме следваща бутилка
                {
                    while (bottles.Any() && cups.Any())
                    {
                        if (bottles.Peek() >= cups.Peek()) // ако чашата се напълни
                        {
                            wastedLittersOfWater += (bottles.Pop() - cups.Dequeue());
                        }
                        else if (bottles.Peek() < cups.Peek()) // ако чашата е все още празна => продължаваме със следващата бутилка
                        {
                            int currentCup = cups.Peek();
                            while (currentCup > 0)
                            {
                                currentCup -= bottles.Pop();
                            }
                            wastedLittersOfWater += -currentCup;
                            cups.Dequeue();
                        }
                    }
                }
            }
            if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}
