using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int messageLenght = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < messageLenght; i++)
            {
                string digits = Console.ReadLine(); // приемаме въведените числа като стринг
                int digitLength = digits.Length; // дължина на стринга
                int digit = int.Parse(digits[0].ToString()); // взимаме стринга на първа позиция и го превръшаме в число
  
                int offset = (digit - 2) * 3; // тая формула хич не ми е ясна и съм я взимал от HINTS

                if (digit == 0) // ако въведеното число е 0 взимаме символа SPACE от ASCII
                {
                    message += (char)(digit + 32); // => SPACE в ASCII
                    continue;
                }

                if (digit == 8 || digit == 9) // If the main digit is 8 or 9, we need to add 1 to the offset
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1; // (offset + digit length - 1).
                message += (char)(letterIndex + 97); // начало на малките букви в ASCII таблицата
            }

            Console.WriteLine(message);

        }
    }
}
