using System;

namespace _07._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //При +  -   * трябва да се отпечатат резултата и дали той е четен или нечетен
            //При /  – резултата
            //При %  – остатъка
            //   Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели.
            //   В този случай трябва да се отпечата специално съобщениe.

            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char operat = Convert.ToChar(Console.ReadLine());   

            double result = 0;



            switch (operat)
            {
                case '+':
                    result = N1 + N2;
                    {
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - odd");
                        }
                    }
                    break;
                case '-':
                    result = N1 - N2;
                    {
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - odd");
                        }
                    }
                    break;
                case '*':
                    result = N1 * N2;
                    {
                        if (result % 2 == 0)
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - even");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result} - odd");
                        }
                    }
                    break;
                case '/':
                    result = N1 / N2;
                    {
                        if (N2 == 0)
                        {
                            Console.WriteLine($"Cannot divide {N1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result:f2}");
                            
                        } 
                    }
                    break;
                case '%':
                    result = N1 % N2;
                    {
                        if (N2 == 0)
                        {
                            Console.WriteLine($"Cannot divide {N1} by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{N1} {operat} {N2} = {result}");

                        }
                    }
                    break;
            }
        }
    }
}
