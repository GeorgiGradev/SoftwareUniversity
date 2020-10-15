using System;

namespace _05._02._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sugarGrams = 0; // 1 pack = 950 gr
            int flourGrams = 0; // 1 pack = 750 gr
            double sugarGramsNew = 0;
            double flourGramsNew = 0;
            double sugarPacks = 0;
            double flourPacks = 0;
            int maxValueSugar = int.MinValue;
            int maxValueFlour = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                 
                sugarGrams = int.Parse(Console.ReadLine());
                flourGrams = int.Parse(Console.ReadLine());

                sugarGramsNew += sugarGrams;
                flourGramsNew += flourGrams;

                if (sugarGrams > maxValueSugar)
                {
                    maxValueSugar = sugarGrams;
                }
                if (flourGrams > maxValueFlour)
                {
                    maxValueFlour = flourGrams;
                }
            }

            sugarPacks = Math.Ceiling(sugarGramsNew / 950);
            flourPacks = Math.Ceiling(flourGramsNew / 750);

            Console.WriteLine($"Sugar: {sugarPacks}");
            Console.WriteLine($"Flour: {flourPacks}");
            Console.WriteLine($"Max used flour is {maxValueFlour} grams, max used sugar is {maxValueSugar} grams.");

        }
    }
}
