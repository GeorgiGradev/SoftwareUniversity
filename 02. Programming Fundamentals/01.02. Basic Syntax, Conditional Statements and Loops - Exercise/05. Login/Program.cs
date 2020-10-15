using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int counter = 0;
            bool isCorrect = true;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string input = Console.ReadLine();
            while (input != password)
            {
                counter++;
                if(counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    isCorrect = false;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            if (isCorrect)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
