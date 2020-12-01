using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _1.Santa_sPresentFactory
{
    class StartUp
    {
        public const int doll = 150;
        public const int woodenTrain = 250;
        public const int teddyBear = 300;
        public const int bicycle = 400;

        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int dolls = 0;
            int woodenTrains = 0;
            int teddyBears = 0;
            int bicycles = 0;

            while (materials.Any() && magicLevel.Any())
            {
                int result = materials.Peek() * magicLevel.Peek();
                if (result == doll || result == woodenTrain || result == teddyBear || result == bicycle)
                {
                    CheckResult(materials, magicLevel, ref dolls, ref woodenTrains, ref teddyBears, ref bicycles, result);
                }
                else if (result < 0)
                {
                    result = materials.Peek() + magicLevel.Peek();
                    materials.Pop(); magicLevel.Dequeue();
                    materials.Push(result);
                }
                else if (result > 0)
                {
                    result = materials.Pop() + 15;
                    magicLevel.Dequeue();
                    materials.Push(result);
                }
                else if (result == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }
                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();
                    }
                }
            }

            // On the first line -print whether you've succeeded in crafting the presents
            //o   "The presents are crafted! Merry Christmas!"
            //o   "No presents this Christmas!"
            if (dolls > 0 && woodenTrains > 0 || teddyBears > 0 && bicycles > 0)
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }


            //•	On the next two lines print the materials and magic that are left, if there are any, otherwise skip the line
            //o   "Materials left: {material1}, {material2}, …"
            //o   "Magic left: {magicValue1}, {magicValue2}, …


            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}");
            }
            if (magicLevel.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}");
            }

            //•	On the next lines print the presents you have crafted at least once, ordered alphabetically in the format:
            //"{toy name}: {amount}"

            var dict = new Dictionary<string, int>();
            if (dolls > 0)
            {
                dict.Add("Doll", dolls);
            }
            if (woodenTrains > 0)
            {
                dict.Add("Wooden train", woodenTrains);
            }
            if (teddyBears > 0)
            {
                dict.Add("Teddy bear", teddyBears);
            }
            if (bicycles > 0)
            {
                dict.Add("Bicycle", bicycles);
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static void CheckResult(Stack<int> materials, Queue<int> magicLevel, ref int dolls, ref int woodenTrains, ref int teddyBears, ref int bicycles, int result)
        {
            if (result == doll)
            {
                dolls++;
            }
            else if (result == woodenTrain)
            {
                woodenTrains++;
            }
            else if (result == teddyBear)
            {
                teddyBears++;
            }
            else if (result == bicycle)
            {
                bicycles++;
            }
            materials.Pop();
            magicLevel.Dequeue();
        }
    }
}
