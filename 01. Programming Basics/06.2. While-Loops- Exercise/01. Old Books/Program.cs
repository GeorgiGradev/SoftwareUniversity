using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int count = 0;

            while (count < n)
            {

                if (book != input)
                {
                    input = Console.ReadLine();
                }
                else if (book == input)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }
                count++;
            }
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {n} books.");
        }
    }
}
