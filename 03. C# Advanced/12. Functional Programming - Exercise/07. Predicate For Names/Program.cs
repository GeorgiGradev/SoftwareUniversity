using System;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> func = ((name, n) =>
            {
                bool isOK = false;
                if (name.Length <= n)
                {
                    isOK = true;
                }
                return isOK;
            });

            for (int i = 0; i < names.Length; i++)
            {
                if (func(names[i], n) == true)
                {
                    Console.WriteLine(names[i]);
                }
            }



        }
    }
}
