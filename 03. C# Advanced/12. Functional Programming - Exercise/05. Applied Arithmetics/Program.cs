using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        private static int[] numbers;
        static void Main()
        {
            //int[] numbers = Console.ReadLine()
            //     .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //     .Select(int.Parse)
            //     .ToArray();

            // string command = Console.ReadLine();

            // Action<string> manipulateNums = command =>
            // {
            //     if (command == "add")
            //     {
            //         numbers = numbers.Select(n => n + 1).ToArray();
            //     }
            //     else if (command == "multiply")
            //     {
            //         numbers = numbers.Select(n => n * 2).ToArray();
            //     }
            //     else if (command == "subtract")
            //     {
            //         numbers = numbers.Select(n => n - 1).ToArray();
            //     }
            //     else if (command == "print")
            //     {
            //         Console.WriteLine(string.Join(" ", numbers));
            //     }
            // };

            // while (command != "end")
            // {
            //     manipulateNums(command);

            //     command = Console.ReadLine();
            // }


            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else
                {
                    Func<int[], int[]> processor = GetProcessor(input);
                    numbers = processor(numbers);
                }
            }

        }

        static Func<int[], int[]> GetProcessor(string input)
        {
            Func<int[], int[]> processor = null;
            if (input == "add")
            {
                processor = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]++;
                    }
                    return arr;
                });
            }
            else if (input == "multiply")
            {
                processor = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]*=2;
                    }
                    return arr;
                });
            }
            else if (input == "subtract")
            {
                processor = new Func<int[], int[]>(arr =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                    return arr;
                });
            }


            return processor;
        }
    }
}