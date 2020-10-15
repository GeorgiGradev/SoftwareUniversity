using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            StringBuilder st = new StringBuilder();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] =='(')
                {
                    int startIndex = i;
                    stack.Push(startIndex);
                }
                else if (expression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string subExpression = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(subExpression);
                }
            }

        }
    }
}
