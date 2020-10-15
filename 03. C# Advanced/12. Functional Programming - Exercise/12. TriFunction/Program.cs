using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            =======================
            !!!!75/100 JUDGE !!!!!!
            =======================
 
            int sumChars = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> func1 = new Func<string, int, bool>((name, charsSum) =>
            {
                bool isCorrect = false;
                int sum = 0;

                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum >= charsSum)
                {
                    isCorrect = true;
                }

                return isCorrect;
            });

            Func<List<string>, Func<string, int, bool>, List<string>> func2 = new Func<List<string>, Func<string, int, bool>, List<string>>((names, func1) =>
            {
                List<string> output = new List<string>();
                foreach (var item in names)
                {
                    if (func1(item, sumChars) == true)
                    {
                        output.Add(item);
                    }
                }
                return output;
            });

            Console.WriteLine(string.Join(" ", func2(names, func1)));

            =======================
            !!!!75/100 JUDGE !!!!!!
            =======================


            */



            var targetCharactersSum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray()
                                                                    .Select(ch => (int)ch).Sum() >= num;

            Func<string[], int, Func<string, int, bool>, string> firstValidName = (arr, num, func) => arr
                .FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, targetCharactersSum, isValidWord);
            Console.WriteLine(result);

        }
    }
}
