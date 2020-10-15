using System;
using System.Text;

namespace _02._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (command == "Substitute")
                {
                    string copy = tokens[1];
                    string paste = tokens[2];
                    if (password.Contains(copy))
                    {
                        password = password.Replace(copy, paste);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
