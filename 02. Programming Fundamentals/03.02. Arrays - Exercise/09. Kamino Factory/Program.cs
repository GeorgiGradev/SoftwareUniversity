using System;
using System.Linq;
namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string commandInput = Console.ReadLine();
            int elementsSum = 0;
            int bestElementsSum = 0;

            int bestIndexCounter = int.MaxValue;
            int bestElelmentsCounter = 0;
            int lineCounter = 0;
            int bestLineCounter = 0;
            string bestDNA = string.Empty;
            bool isBetter = false;

            while (commandInput != "Clone them!")
            {
                int[] input = commandInput
                    .Split("!", StringSplitOptions
                    .RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int indexCounter = 0;
                lineCounter++;
                for (int i = 0; i < input.Length-1; i++)
                {
                    indexCounter++;
                    int elementsCounter = 1;
                    elementsSum = input.Sum();
                    for (int k = i + 1; k < input.Length; k++)
                    {
                        if (input[i] == input[k])
                        {
                            elementsCounter++;
                        }
                        else
                        {
                            break;
                        }
                        if (elementsCounter > bestElelmentsCounter)
                        {
                            bestElelmentsCounter = elementsCounter;
                        }
                        if (indexCounter < bestIndexCounter)
                        {
                            bestIndexCounter = indexCounter;
                            bestElementsSum = elementsSum;
                            bestLineCounter = lineCounter;
                            bestDNA = string.Join(" ", input);
                            isBetter = true;
                        }
                    }
                }

                if (elementsSum > bestElementsSum && isBetter == false) 
                {
                    bestElementsSum = elementsSum;
                    bestIndexCounter = indexCounter;
                    bestDNA = string.Join(" ", input);
                    bestLineCounter = lineCounter;
                }
                commandInput = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestLineCounter} with sum: {bestElementsSum}.");
            Console.WriteLine(bestDNA);
        }
    }
}
// 80 % Judge