using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("data", "input.txt"); 
            using FileStream stream1 = new FileStream(path1, FileMode.OpenOrCreate);
            using StreamReader reader = new StreamReader(stream1); 

            string path2 = Path.Combine("data", "output.txt"); 
            using FileStream stream2 = new FileStream(path2, FileMode.OpenOrCreate);
            using StreamWriter writer = new StreamWriter(stream2);

            int counter = 1;

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                else
                {
                    writer.WriteLine($"{counter++}. {line}");
                }
            }
        }
    }
}
