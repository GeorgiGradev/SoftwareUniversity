using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            decimal total = 0;

            foreach (var item in input)
            {
                decimal result = 0;
                decimal letter1 = item[0];
                decimal letter2 = item[^1];
                string number1 = item.Remove(0, 1);
                decimal number = decimal.Parse(number1.Remove(number1.Length-1, 1));
            
                if (letter1 >= 65 && letter1 <= 90) // първа Главна буква
                {
                    letter1 -= 64;
                    result = number / letter1;
                }
                else // първа малка буква
                {
                    letter1 -= 96;
                    result = number * letter1;
                }
                if (letter2 >= 65 && letter2 <= 90) // последна Главна буква
                {
                    letter2 -= 64;
                    result -= letter2;
                }
                else // последна малка буква
                {
                    letter2 -= 96;
                    result += letter2;
                }
                total += result;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
