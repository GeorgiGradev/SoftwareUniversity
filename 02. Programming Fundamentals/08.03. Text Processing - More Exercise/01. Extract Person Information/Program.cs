using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                StringBuilder name = new StringBuilder();
                StringBuilder age = new StringBuilder();
                bool isTrue = false;
                string input = Console.ReadLine();
                for (int k = 0; k < input.Length; k++)
                {
                   if (input[k] == '|')
                    {
                        isTrue = false;
                        break;
                    }
                    if (isTrue)
                    {
                        name.Append(input[k]);
                    }
                    if (input[k] == '@')
                    {
                        isTrue = true;
                    }
                }
                for (int k = 0; k < input.Length; k++)
                {
                    if (input[k] == '*')
                    {
                        isTrue = false;
                        break;
                    }
                    if (isTrue)
                    {
                        age.Append(input[k]);
                    }
                    if (input[k] == '#')
                    {
                        isTrue = true;
                    }
                }
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
