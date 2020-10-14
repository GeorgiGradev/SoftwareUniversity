using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бензин – 2.22 лева за един литър
            //Дизел – 2.33 лева за един литър
            //Газ – 0.93 лева за литър

            // Ако има карта: 
            //     18 ст.за литър бензин / 2.04
            //     12 ст.за литър дизел / 2.21
            //      8 ст.за литър газ./ 0.85

            // Ако зареди:
            //      между 20 и 25 литра включително = 8 % отстъпка
            //      мад 25 литра = 10 % отстъпка


            string fuel = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            if (fuel == "Gas")
            {
                if (card == "Yes")
                {
                    if (volume > 25)
                    {
                         Console.WriteLine($"{volume * 0.85 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                        Console.WriteLine($"{volume * 0.85 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 0.85:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (volume > 25)
                    {
                        Console.WriteLine($"{volume * 0.93 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                         Console.WriteLine($"{volume * 0.93 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 0.93:F2} lv.");
                    }
                }    
            }
            else if (fuel == "Gasoline")
            {
                if (card == "Yes")
                {
                    if (volume > 25)
                    {
                        Console.WriteLine($"{volume * 2.04 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                        Console.WriteLine($"{volume * 2.04 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 2.04:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (volume > 25)
                    {
                        Console.WriteLine($"{volume * 2.22 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                        Console.WriteLine($"{volume * 2.22 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 2.22:F2} lv.");
                    }
                }
            }
            else if (fuel == "Diesel")
            {
                if (card == "Yes")
                {
                    if (volume > 25)
                    {
                        Console.WriteLine($"{volume * 2.21 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                        Console.WriteLine($"{volume * 2.21 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 2.21:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (volume > 25)
                    {
                        Console.WriteLine($"{volume * 2.33 * 0.90:F2} lv.");
                    }
                    else if (volume > 20)
                    {
                        Console.WriteLine($"{volume * 2.33 * 0.92:F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{volume * 2.33:F2} lv.");
                    }
                }
            }
        }
    }
}
