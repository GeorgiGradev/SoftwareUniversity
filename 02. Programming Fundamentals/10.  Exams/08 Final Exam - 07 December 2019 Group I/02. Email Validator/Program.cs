using System;
using System.Text;
using System.Threading;

namespace _02._Email_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Complete")
            {
                string[] tokens = input.Split();
                string command = tokens[0];

                if (command == "Make")
                {
                    string upperLower = tokens[1];
                    if (upperLower == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (upperLower == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (command == "GetDomain")
                {
                    int domainLength = int.Parse(tokens[1]);
                    string domain = email.Substring(email.Length - domainLength, domainLength);
                    Console.WriteLine(domain);
                }
                else if (command == "GetUsername")
                {
                    if (email.Contains("@"))
                    {
                        int index = email.IndexOf("@");
                        string user = email.Substring(0, index);
                        Console.WriteLine(user);
                    }
                    else
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    }
                }
                else if (command == "Replace")
                {
                    char @char = char.Parse(tokens[1]);
                    email = email.Replace(@char, '-');
                    Console.WriteLine(email);
                }
                else if (command == "Encrypt")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < email.Length; i++)
                    {
                        sb.Append((int)email[i] + " ");
                    }
                    string encrypted = sb.ToString().TrimEnd(); ;
                    Console.WriteLine(encrypted);
                }
            }
        }
    }
}
