using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");
                string command = input[0];
                

                if (command == "END")
                {
                    break;
                }
                else
                {
                    string carPlate = input[1];
                    if (command == "IN")
                    {
                        set.Add(carPlate);
                    }
                    else if (command == "OUT")
                    {
                        if (set.Contains(carPlate))
                        {
                            set.Remove(carPlate);
                        }
                    }
                }
            }

            if (set.Count > 0)
            {
                foreach (var item in set)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
