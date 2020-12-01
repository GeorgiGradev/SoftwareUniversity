using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            Data = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public List<Car> Data { get; set; }
        public int Count => Data.Count;

        public void Add(Car car)
        {
            if (Capacity > Data.Count)
            {
                Data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            return Data.Remove(Data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model));

            //Car car = Data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            //if (car == null)
            //{
            //    return false;
            //}
            //else
            //{
            //    Data.Remove(car);
            //    return true;
            //}
        }
        public Car GetLatestCar()
        {
            return Data.OrderByDescending(x => x.Year).FirstOrDefault();
        }
        public Car GetCar(string manufacturer, string model)
        {
            return Data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in Data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
