using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<artist>[A-Z][a-z\s*'*]+):(?<song>[A-Z\s*]+)$";
            string input = string.Empty;
            string encryptedText = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    string artist = match.Groups["artist"].Value;
                    int key = int.Parse(artist.Length.ToString());
                    encryptedText = string.Empty;

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ' ' || input[i] == '\'')
                        {
                            encryptedText += input[i];
                        }
                        else if (input[i] == ':')
                        {
                            encryptedText += '@';
                        }
                        else
                        {
                            if (input[i] >= 65 && input[i] <= 90) // главни букви
                            {
                                if (input[i] + key > 90)
                                {
                                    encryptedText += (char)(input[i] + key - 26);
                                }
                                else
                                {
                                    encryptedText += (char)(input[i] + key);
                                }
                            }
                            else if (input[i] >= 97 && input[i] <= 122) //малки букви
                            {
                                if (input[i] + key > 122)
                                {
                                    encryptedText += (char)(input[i] + key - 26);
                                }
                                else
                                {
                                    encryptedText += (char)(input[i] + key);
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                Console.WriteLine($"Successful encryption: {encryptedText}");
            }

        }
    }
}
