using System;
using System.ComponentModel;
using System.Net.Security;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var item in bannedWords)
            {
                int index = text.IndexOf(item);
                while (index != -1)
                {
                    text = text.Replace(item, new string('*', item.Length));
                    index = text.IndexOf(item);
                }
            }  
            Console.WriteLine(text);
        }
    }
}