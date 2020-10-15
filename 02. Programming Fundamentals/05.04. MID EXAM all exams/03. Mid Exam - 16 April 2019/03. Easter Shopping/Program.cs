using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "Include")
                {
                    string shop = command[1];
                    input.Add(shop);
                }
                else if (command[0] == "Visit")
                {
                    string firstLast = command[1];
                    int numberToRemove = int.Parse(command[2]);
                    if (input.Count >= numberToRemove)
                    {
                        if (firstLast == "first")
                        {
                            for (int k = 0; k < numberToRemove; k++)
                            {
                                input.RemoveAt(0);
                            }
                        }
                        else if (firstLast == "last")
                        {
                            for (int k = 0; k < numberToRemove; k++)
                            {
                                input.RemoveAt(input.Count-1);
                            }
                        }
                    }
                }
                else if (command[0] == "Prefer")
                {
                    int index1 = int.Parse(command[1]);
                    int index2 = int.Parse(command[2]);
                    if (index1 <= input.Count - 1 && index2 <= input.Count - 1)
                    {
                        if (index2 > index1)
                        {
                            string shop1 = input[index1];
                            string shop2 = input[index2];
                            input.RemoveAt(index2);
                            input.RemoveAt(index1);
                            input.Insert(index1, shop2);
                            input.Insert(index2, shop1);
                        }
                        else if (index1 > index2)
                        {
                            string shop1 = input[index1];
                            string shop2 = input[index2];
                            input.RemoveAt(index1);
                            input.RemoveAt(index2);
                            input.Insert(index2, shop1);
                            input.Insert(index1, shop2);
                        }
                    }
                }
                else if (command[0] == "Place")
                {
                    string shop = command[1];
                    int index = int.Parse(command[2]);
                    if (input.Count - 1 >= index)
                    {
                        input.Insert(index + 1, shop);
                    }
                }
            }
            Console.WriteLine("Shops left:");
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
