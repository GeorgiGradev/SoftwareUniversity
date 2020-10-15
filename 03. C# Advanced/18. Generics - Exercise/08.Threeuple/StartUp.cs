using System;
using System.Text;

namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string name = $"{input[0]} {input[1]}";
            string address = input[2];
            StringBuilder sb = new StringBuilder();
            for (int i = 3; i < input.Length; i++)
            {
                sb.Append($"{input[i]} ");
            }
            string city = sb.ToString().TrimEnd();
            Threeuple<string, string, string> threeuple1 
                = new Threeuple<string, string, string>(name, address, city);
            Console.WriteLine(threeuple1);



            input = Console.ReadLine().Split();
            name = input[0];
            int beer = int.Parse(input[1]);
            string isDrunk = input[2];
            bool boolResult = Threeuple<string, int, bool>.IsDrunk(isDrunk);
            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(name, beer, boolResult);
            Console.WriteLine(threeuple2);



            input = Console.ReadLine().Split();
            name = input[0];
            double account = double.Parse(input[1]);
            string bank = input[2];
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(name, account, bank);
            Console.WriteLine(threeuple3);
        }
    }
}
