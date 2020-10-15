using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            List<int> numberList = new List<int>();
            List<char> charList = new List<char>();

            foreach (char symbol in encryptedMessage)
            {
                if (char.IsDigit(symbol))
                {
                    int number = int.Parse(symbol.ToString());
                    numberList.Add(number);
                }
                else
                {
                    charList.Add(symbol);
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int index = 0; index < numberList.Count; index++)
            {
                if (index % 2 == 0)
                {
                    takeList.Add(numberList[index]);
                }
                else
                {
                    skipList.Add(numberList[index]);
                }
            }

            string result = string.Empty;

            int total = 0;
            for (int index = 0; index < skipList.Count; index++)
            {
                int skipCount = skipList[index];
                int takeCount = takeList[index];
                result += new string(charList.Skip(total).Take(takeCount).ToArray());
                total += skipCount + takeCount;
            }
            Console.WriteLine(result);
        }
    }
}
