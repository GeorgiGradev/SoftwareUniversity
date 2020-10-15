using System;

namespace _04._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordCommand = Console.ReadLine();
            int letterSum = 0;
            double result = 0;
            double powerfulWord = 0;
            string winner = "";

            while (wordCommand != "End of words")
            {
                for (int i = 0; i < wordCommand.Length; i++)
                {
                    letterSum += wordCommand[i];
                }
                if (wordCommand[0] == 'a' || wordCommand[0] == 'e' || wordCommand[0] == 'i' || wordCommand[0] == 'o'
                    || wordCommand[0] == 'u' || wordCommand[0] == 'y' || wordCommand[0] == 'A' || wordCommand[0] == 'E'
                    || wordCommand[0] == 'I' || wordCommand[0] == 'O' || wordCommand[0] == 'U' || wordCommand[0] == 'Y')
                {
                    result = letterSum * wordCommand.Length;
                }
                else
                {
                    result = letterSum / wordCommand.Length;
                }
                 if (result > powerfulWord)
                {
                    powerfulWord = result;
                    winner = wordCommand;
                }
                letterSum = 0;
                wordCommand = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {winner} - {powerfulWord}");
        }
    }
}
