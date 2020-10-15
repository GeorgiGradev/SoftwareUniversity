using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int openingBracketCounter = 0;
            int closingBracketCounter = 0;
            bool isBalanced = true;

            for (int i = 0; i < lines; i++)
            {
                string command = Console.ReadLine();

                if (command == "(")
                {
                    openingBracketCounter++;
                }
                if (command == ")")
                {
                    closingBracketCounter++;
                }
                if (closingBracketCounter > openingBracketCounter)
                {
                    isBalanced = false;
                    break;
                }
            }
            if (isBalanced && closingBracketCounter == openingBracketCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
