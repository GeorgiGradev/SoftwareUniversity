using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");


            foreach (var item in input)
            {
                bool isTrue = true;
                for (int i = 0; i < item.Length; i++)
                {
                    if ((item[i] == '-'
                        || item[i] == '_'
                        || char.IsLetter(item[i])
                        || char.IsNumber(item[i]))
                        && (item.Length >= 3
                        && item.Length <= 16))
                    {
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
