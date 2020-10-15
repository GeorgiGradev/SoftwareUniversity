using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете от конзолата число (не непременно цяло) и преобразува числото от инчове в сантиметри. За целта умножава инчовете по 2.54 (защото 1 инч = 2.54 сантиметра).
            double inch = double.Parse(Console.ReadLine());

            double cm = inch * 2.54;

            Console.WriteLine(cm);
        }
    }
}
