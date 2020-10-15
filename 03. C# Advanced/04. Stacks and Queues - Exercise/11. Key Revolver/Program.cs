using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelCapacity = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfInteligence = int.Parse(Console.ReadLine());

            Stack<int> bulletsStack = new Stack<int>(bullets);
            Queue<int> locksQueue = new Queue<int>(locks);
            int bulletsAtBeginning = bulletsStack.Count();
            int barrelCount = 0;
            int usedBullets = 0;

            while (bulletsStack.Any() && locksQueue.Any())
            {
                if (bulletsStack.Peek() <= locksQueue.Peek())
                {
                    Console.WriteLine("Bang!");
                    bulletsStack.Pop();
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletsStack.Pop();
                }
                usedBullets++;
                barrelCount++;
                if (barrelCount == gunBarrelCapacity && bulletsStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrelCount = 0;
                }
            }
            if (locksQueue.Count == 0 && bulletsStack.Count >= 0)
            {
                int bulletsLeft = bulletsStack.Count();
                int usedBulletsPrice = (bulletsAtBeginning - bulletsLeft) * bulletPrice;
                int earnedMoney = valueOfInteligence - usedBulletsPrice;
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${earnedMoney}");
            }
            else
            {
                int locksLeft = locksQueue.Count();
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
        }
    }
}
