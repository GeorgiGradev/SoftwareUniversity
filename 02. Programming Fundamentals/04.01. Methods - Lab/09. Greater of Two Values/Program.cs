using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
                string valueType = Console.ReadLine().ToLower();

                if (valueType == "int")
                {
                    int value1 = int.Parse(Console.ReadLine());
                    int value2 = int.Parse(Console.ReadLine());

                    int maxInt = getMaxInt(value1, value2);
                    Console.WriteLine(maxInt);
                }
                else if (valueType == "char")
                {
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());

                    char maxChar = getMaxChar(ch1, ch2);
                    Console.WriteLine(maxChar);
                }
                else if (valueType == "string")
                {
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();

                    string maxStr = getMaxStr(str1, str2);
                    Console.WriteLine(maxStr);
                }
            }

            static int getMaxInt(int value1, int value2)
            {
                if (value1 > value2)
                {
                    return value1;
                }
                else
                {
                    return value2;
                }
            }

            static char getMaxChar(char ch1, char ch2)
            {
                if (ch1 > ch2)
                {
                    return ch1;
                }
                else
                {
                    return ch2;
                }
            }

            static string getMaxStr(string str1, string str2)
            {
                if (str1.CompareTo(str2) >= 0)
                {
                    return str1;
                }
                else
                {
                    return str2;
                }
            }
    }
}
