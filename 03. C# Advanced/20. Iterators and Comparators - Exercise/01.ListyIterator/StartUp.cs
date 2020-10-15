using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _01.ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            List<string> elements = command.Split().Skip(1).ToList();
            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            while (command != "END")
            {
                if (command.Contains("Move"))
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command.Contains("Print"))
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
                else if (command.Contains("HasNext"))
                {
                     bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
                command = Console.ReadLine();
            }









        }
    }
}
