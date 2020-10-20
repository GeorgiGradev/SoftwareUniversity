using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffect = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());

            const int daturaBombs = 40;
            const int cherryBombs = 60;
            const int smokeDecoyBombs = 120;
            int daturaCount = 0;
            int cherryCount = 0;
            int smokeCount = 0;
            bool isDone = false;

            while(bombEffect.Any() && bombCasing.Any())
            {
                int currentSituation = bombEffect.Peek() + bombCasing.Peek();
                if (currentSituation == daturaBombs)
                {
                    daturaCount++;
                    bombEffect.Dequeue(); bombCasing.Pop();
                }
                else if (currentSituation == cherryBombs)
                {
                    cherryCount++;
                    bombEffect.Dequeue(); bombCasing.Pop();
                }
                else if (currentSituation == smokeDecoyBombs)
                {
                    smokeCount++;
                    bombEffect.Dequeue(); bombCasing.Pop();
                }
                else
                {
                    bombCasing.Push(bombCasing.Pop() - 5);
                }

                if (daturaCount >= 3 && cherryCount >= 3 && smokeCount >= 3 )
                {
                    isDone = true;
                    break;
                }
            }
            if (isDone)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffect.Any())
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffect)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (bombCasing.Any())
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeCount}");
        }
    }
}
