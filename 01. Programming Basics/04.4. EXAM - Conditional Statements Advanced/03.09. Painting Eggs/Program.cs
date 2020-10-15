using System;

namespace _03._09._Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int eggsPrice = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            switch (size)
            {
                case "Large":
                    {
                        if (color == "Red")
                        {
                            totalPrice = eggsPrice * 16;
                        }
                        else if (color == "Green")
                        {
                            totalPrice = eggsPrice * 12;
                        }
                        else if (color == "Yellow")
                        {
                            totalPrice = eggsPrice * 9;
                        }
                        break;
                    }
                case "Medium":
                    {
                        if (color == "Red")
                        {
                            totalPrice = eggsPrice * 13;
                        }
                        else if (color == "Green")
                        {
                            totalPrice = eggsPrice * 9;
                        }
                        else if (color == "Yellow")
                        {
                            totalPrice = eggsPrice * 7;
                        }
                        break;
                    }
                case "Small":
                    {
                        if (color == "Red")
                        {
                            totalPrice = eggsPrice * 9;
                        }
                        else if (color == "Green")
                        {
                            totalPrice = eggsPrice * 8;
                        }
                        else if (color == "Yellow")
                        {
                            totalPrice = eggsPrice * 5;
                        }
                        break;
                    }
            }
            totalPrice *= 0.65;

            Console.WriteLine($"{totalPrice:F2} leva.");
        }
    }
}
