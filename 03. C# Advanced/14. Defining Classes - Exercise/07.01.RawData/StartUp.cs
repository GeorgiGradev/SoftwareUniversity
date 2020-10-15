using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace _07._01.RawData
{
    public class StartUp
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1pressure = double.Parse(input[5]);
                int tire1age = int.Parse(input[6]);
                double tire2pressure = double.Parse(input[7]);
                int tire2age = int.Parse(input[8]);
                double tire3pressure = double.Parse(input[9]);
                int tire3age = int.Parse(input[10]);
                double tire4pressure = double.Parse(input[11]);
                int tire4age = int.Parse(input[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1pressure, tire1age, tire2pressure, tire2age, tire3pressure, tire3age, tire4pressure, tire4age);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                HashSet<Car> result = cars.
                    Where(c => c.Cargo.Type == "fragile"
                    && c.Tires.Any(x => x.Pressure < 1)).ToHashSet();

                Console.WriteLine(string.Join(Environment.NewLine, result));

            }
            else if (command == "flamable")
            {
                HashSet<Car> result = cars
                    .Where(c => c.Cargo.Type == "flamable"
                    && c.Engine.Power > 250).ToHashSet();


                Console.WriteLine(string.Join(Environment.NewLine, result));

            }
        }
    }
}
