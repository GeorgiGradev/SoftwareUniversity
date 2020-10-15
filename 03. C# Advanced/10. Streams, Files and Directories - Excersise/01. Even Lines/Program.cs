using System;
using System.IO;
using System.Linq;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = Path.Combine("text.txt");

            using StreamReader reader = new StreamReader(path1);


            int counter = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    line = ReplaceAll(line);

                    line = string.Join(" ", line.Split(' ').Reverse());
                    Console.WriteLine(line);
                }
                counter++;
            }
        }

        public static string ReplaceAll(string line)
        {
            line = line.Replace('-', '@');
            line = line.Replace(',', '@');
            line = line.Replace('.', '@');
            line = line.Replace('!', '@');
            line = line.Replace('?', '@');
            return line;
        }
    }
}
