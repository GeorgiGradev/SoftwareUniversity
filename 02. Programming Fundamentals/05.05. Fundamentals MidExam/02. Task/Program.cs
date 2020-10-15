using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Task
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string end = Console.ReadLine();
                if (end == "end")
                {
                    break;
                }
                string[] tokens = end
                    .Split()
                    .ToArray();

                string command = tokens[0];
                if (command == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    if (index1 >= 0 && index2 >= 0 && input.Count - 1 >= index1 && input.Count - 1 >= index2)
                    {

                        int num1 = input[index1];
                        int num2 = input[index2];

                        if (index2 > index1)
                        {
                            input.RemoveAt(index2);
                            input.RemoveAt(index1);
                            input.Insert(index1, num2);
                            input.Insert(index2, num1);
                        }
                        else if (index1 > index2)
                        {
                            input.RemoveAt(index1);
                            input.RemoveAt(index2);
                            input.Insert(index2, num1);
                            input.Insert(index1, num2);
                        }
                    }
                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);

                    if (index1 >= 0 && index2 >= 0 && input.Count - 1 >= index1 && input.Count - 1 >= index2)
                    {
                        int num1 = input[index1];
                        int num2 = input[index2];

                        int newNum = num1 * num2;
                        input.RemoveAt(index1);
                        input.Insert(index1, newNum);
                    }
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
