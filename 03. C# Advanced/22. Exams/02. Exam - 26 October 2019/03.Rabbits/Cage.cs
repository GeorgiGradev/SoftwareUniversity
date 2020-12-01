using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            return data.Remove(data.FirstOrDefault(x => x.Name == name));
        }
        public void RemoveSpecies(string species)
        {
            data.RemoveAll(x => x.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            foreach (var item in data)
            {
                if (item.Name == name)
                {
                    item.Available = false;
                    return item;
                }
            }
            return null;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> list = new List<Rabbit>();
            foreach (var item in data)
            {
                if (item.Species == species)
                {
                    item.Available = false;
                    list.Add(item);
                }
            }
            return list.ToArray();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            foreach (var item in data)
            {
                if (item.Available == true)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
