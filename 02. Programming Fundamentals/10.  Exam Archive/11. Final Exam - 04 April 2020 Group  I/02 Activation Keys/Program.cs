using System;

namespace _02_Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] tokens = input.Split(">>>");
                string command = tokens[0];

                if (command == "Contains")
                {
                    string substring = tokens[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string upperLower = tokens[1];
                    int startIndex = int.Parse(tokens[2]);
                    int endIndex = int.Parse(tokens[3]);

                    if (upperLower == "Upper")
                    {
                        string changed = activationKey.Substring(startIndex, endIndex - startIndex);
                        string changed1 = changed.ToUpper();
                        activationKey = activationKey.Replace(changed, changed1);
                        Console.WriteLine(activationKey);
                    }
                    else if (upperLower == "Lower")
                    {
                        string changed = activationKey.Substring(startIndex, endIndex - startIndex);
                        string changed1 = changed.ToLower();
                        activationKey = activationKey.Replace(changed, changed1);
                        Console.WriteLine(activationKey);
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
