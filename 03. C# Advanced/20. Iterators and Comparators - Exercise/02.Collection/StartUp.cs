using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> elements = command.Split().Skip(1).ToList();
            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);
            command = Console.ReadLine();

            while (command != "END")
            {
                if (command == "Move")
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (InvalidOperationException exeption)
                    {
                        Console.WriteLine(exeption.Message);
                    }
                }
                else if (command == "HasNext")
                {
                     bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
                else if (command == "PrintAll")
                {
                    listyIterator.PrintAll();
                }
                command = Console.ReadLine();
            }
        }
    }
}
