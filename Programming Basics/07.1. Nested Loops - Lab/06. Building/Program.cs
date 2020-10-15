using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorNumber = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floorNumber; i > 0 ; i--)
            {
                
                if (floorNumber == 1) // Ако има само един етаж, то има само големи апартаменти
                {
                    for (int k = 0; k < rooms; k++)
                    {
                        Console.Write($"L{i}{k} ");
                    }
                    break;
                }
                else if (i % 2 == 0) // На всеки четен етаж има само офиси
                {
                    int evenFloorRoom = 0;
                    for (evenFloorRoom = 0; evenFloorRoom < rooms; evenFloorRoom++)
                    {
                        if (floorNumber != i)
                        {
                            Console.Write($"O{i}{evenFloorRoom} ");
                        }
                        else
                        {
                            Console.Write($"L{i}{evenFloorRoom} ");
                        }
                    }
                    Console.WriteLine();
                }
                else if (i % 2 != 0) // На всеки нечетен етаж има само апартаменти
                {
                    int oddRoom = 0;
                    for (oddRoom = 0; oddRoom < rooms; oddRoom++)
                    {
                        if (floorNumber != i)
                        {
                            Console.Write($"A{i}{oddRoom} ");
                        }
                        else
                        {
                            Console.Write($"L{i}{oddRoom} ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
