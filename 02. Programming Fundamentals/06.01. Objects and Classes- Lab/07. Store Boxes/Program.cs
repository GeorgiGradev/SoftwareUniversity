using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        class Box
        {
            public string SerialNumber { get; set; }
            public string ItemName { get; set; }
            public int ItemQuantity { get; set; }
            public double BoxPrice { get; set; }
            public double ItemPrice { get; set; }
        }
        static void Main(string[] args)
        {

            List<Box> output = new List<Box>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                
                string[] input = command.Split();


                string serialNumber = input[0];
                string itemName = input[1];
                int itemQuantity = int.Parse(input[2]);
                double itemPrice = double.Parse(input[3]);
                double boxPrice = itemPrice * itemQuantity;

                Box box = new Box();

                box.SerialNumber = serialNumber;
                box.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.ItemPrice = itemPrice;
                box.BoxPrice = itemPrice * itemQuantity;

                output.Add(box);

            }

            List<Box> sortedBox = output.OrderBy(sort => sort.BoxPrice).ToList();
            sortedBox.Reverse();

            foreach (Box box in sortedBox)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${box.ItemPrice:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:f2}");
            }
        }
    }
}
