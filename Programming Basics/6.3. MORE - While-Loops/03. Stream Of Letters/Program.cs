using System;

namespace _03._Stream_Of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string resultLetter = "";

            int counterC = 0;
            int counterO = 0;
            int counterN = 0;
            string lastResultLetter = "";

            while (command != "End")
            {
                char symbol = char.Parse(command);
                int symbolInNumber = (int)symbol;

                if ((symbolInNumber >= 65 && symbolInNumber <= 90) || (symbolInNumber >= 97 && symbolInNumber <= 122))
                {
                    if (command == "c")
                    {
                        counterC++;
                        if (counterC > 1)
                        {
                            resultLetter += command;
                        }
                    }
                    else if (command == "o")
                    {
                        counterO++;
                        if (counterO > 1)
                        {
                            resultLetter += command;
                        }
                    }
                    else if (command == "n")
                    {
                        counterN++;
                        if (counterN > 1)
                        {
                            resultLetter += command;
                        }
                    }
                    else
                    {
                        resultLetter += command;
                    }
                    
                    if (counterC >= 1 && counterO >= 1 && counterN >= 1)
                    {
                        resultLetter += char.ConvertFromUtf32(32);
                        counterC = 0;
                        counterO = 0;
                        counterN = 0;
                        lastResultLetter = resultLetter;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(lastResultLetter);
        }
    }
}
