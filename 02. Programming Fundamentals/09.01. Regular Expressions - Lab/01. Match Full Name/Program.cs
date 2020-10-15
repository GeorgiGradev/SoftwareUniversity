using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string solution = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

            MatchCollection matches = Regex.Matches(input, solution);

            foreach  (Match name in matches)
            {
                Console.Write($"{name.Value} ");
            }

        }
    }
}
