using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Last_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string commandEND = Console.ReadLine();

            while (commandEND != "END")
            {
                string[] command = commandEND
                    .Split()
                    .ToArray();

                if (command[0] == "Change")
                {
                    int painingNumber = int.Parse(command[1]);
                    int changeNumber = int.Parse(command[2]);

                    if (input.Contains(painingNumber))
                    {
                        int index = input.IndexOf(painingNumber);
                        input.RemoveAt(index);
                        input.Insert(index, changeNumber);
                    }
                }
                else if (command[0] == "Hide")
                {
                    int painingNumber = int.Parse(command[1]);
                    if (input.Contains(painingNumber))
                    {
                        int index = input.IndexOf(painingNumber);
                        input.RemoveAt(index);
                    }
                }
                else if (command[0] == "Switch")
                {
                    int painingNumber1 = int.Parse(command[1]);
                    int painingNumber2 = int.Parse(command[2]);
                    if (input.Contains(painingNumber1) && input.Contains(painingNumber2))
                    {

                        int index1 = input.IndexOf(painingNumber1);
                        int index2 = input.IndexOf(painingNumber2);
                        if (index1 < index2)
                        {
                            input.RemoveAt(index2);
                            input.RemoveAt(index1);
                            input.Insert(index1, painingNumber2);
                            input.Insert(index2, painingNumber1);
                        }
                        else if(index2 < index1)
                        {
                            input.RemoveAt(index1);
                            input.RemoveAt(index2);
                            input.Insert(index2, painingNumber1);
                            input.Insert(index1, painingNumber2);
                        }
                    }
                }
                else if (command[0] == "Insert")
                {
                    int place = int.Parse(command[1]);
                    int painingNumber = int.Parse(command[2]);
                    if (input.Count >= place)
                    {
                        int index = place + 1;
                        input.Insert(index, painingNumber);
                    }
                }
                else if (command[0] == "Reverse")
                {
                    input.Reverse();
                }
                commandEND = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }
    }
}
