using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            Data = new List<Present>();
        }


        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => Data.Count;
        public List<Present> Data { get; set; }

    public void Add(Present present)
        {
            if (Count < Capacity)
            {
                Data.Add(present);
            }
        }
        public bool Remove(string name)
        {
            Present present = Data.FirstOrDefault(x => x.Name == name);
            return Data.Remove(present);
       
            //return data.Remove(data.FirstOrDefault(x => x.Name == name));

        }
        public Present GetHeaviestPresent()
        {
            return Data.OrderByDescending(x => x.Weight).FirstOrDefault();
        }
        public Present GetPresent(string name)
        {
            return Data.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} bag contains:");
            foreach (var item in Data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();



        }
    }
}
