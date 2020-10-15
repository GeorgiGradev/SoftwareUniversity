using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> stack = new Stack<string>();
            stack.Push(text);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1") // appends to the end of the text
                {
                    string textToAppend = command[1];
                    text += textToAppend;
                    stack.Push(text);
                }
                else if (command[0] == "2") // erases the last count elements
                {
                    int countElementsToErase = int.Parse(command[1]);
                    text = text.Remove(text.Length - countElementsToErase, countElementsToErase);
                    stack.Push(text);
                }
                else if (command[0] == "3") // returns the element at position index 
                {
                    int indexToReturn = int.Parse(command[1]);
                    text = stack.Peek();
                    Console.WriteLine(text[indexToReturn - 1]);
                }
                else if (command[0] == "4") // undoes the last not undone command of type 1 / 2 
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        text = string.Empty;
                        stack.Push(text);
                    }
                    text = stack.Peek();
                }
            }
        }
    }
}
