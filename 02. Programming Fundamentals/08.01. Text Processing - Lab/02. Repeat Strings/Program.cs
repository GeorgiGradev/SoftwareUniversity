using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder output = new StringBuilder();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    output.Append(item);
                }
            }
            Console.WriteLine(output);
        }
    }
}
