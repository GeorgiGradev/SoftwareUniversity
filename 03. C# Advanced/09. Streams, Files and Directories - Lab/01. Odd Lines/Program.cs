using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;

namespace _01._Odd_Lines
{
    class Program 
    {
        static void Main(string[] args)
        {
            string path = Path.Combine("data", "input.txt"); // създаване на път към текстовия файл
            using FileStream stream1 = new FileStream(path, FileMode.OpenOrCreate); // създаване на стрийм към текстовия файл
            using StreamReader reader = new StreamReader(stream1); // създаване на четящ стрйм към текстовия файл

            string dest = Path.Combine("data", "output.txt"); // създаване на път към новия текстов файл
            using FileStream stream2 = new FileStream(dest, FileMode.OpenOrCreate); // създаване на стрийм към новия текстов файл
            using StreamWriter writer = new StreamWriter(stream2);// създаване на пишещ стрйм към новия текстов файл

            int counter = 0;

            while (true)
            {          
                string line = reader.ReadLine(); // прочитаме ред от входящия текст
                if (line == null)
                {
                    break;
                }
                else
                {
                    if (counter % 2 != 0)
                    {
                        writer.WriteLine($"{counter}. {line}"); // записваме ред от първия във втория файл
                    }
                    counter++;
                } 
            }
        }
    }
}

