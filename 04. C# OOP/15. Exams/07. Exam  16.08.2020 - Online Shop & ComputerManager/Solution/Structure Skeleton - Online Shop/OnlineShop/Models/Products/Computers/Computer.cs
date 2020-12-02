using OnlineShop.Common.Constants;
using OnlineShop.Models.Products.Components;
using OnlineShop.Models.Products.Peripherals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineShop.Models.Products.Computers
{
    public abstract class Computer : Product, IComputer
    {
        private readonly ICollection<IComponent> components;
        private readonly ICollection<IPeripheral> peripherals;

        protected Computer(int id, string manufacturer, string model, decimal price, double overallPerformance)
           : base(id, manufacturer, model, price, overallPerformance)
        {
            this.components = new List<IComponent>();
            this.peripherals = new List<IPeripheral>();
        }

        public IReadOnlyCollection<IComponent> Components
            => this.components.ToList().AsReadOnly(); // TODO Ако не работи да се мине към лист горе в полето (видео 02:47:00)

        public IReadOnlyCollection<IPeripheral> Peripherals
            => this.peripherals.ToList().AsReadOnly(); // Ако не работи да се мине към лист горе в полето (видео 02:47:00)

        public override double OverallPerformance
            => CaclcualteOverallPerformance();

        public override decimal Price
            => this.Peripherals.Sum(x => x.Price)
            + this.Components.Sum(x => x.Price) + base.Price;
          
        public void AddComponent(IComponent component)
        {
            if (this.components.Any(x => x.GetType() == component.GetType()))
            { //TODO Check ID?
                throw new ArgumentException
                    (string.Format(ExceptionMessages.ExistingComponent, component.GetType().Name, this.GetType().Name, this.Id));
            }
            components.Add(component);
        }

        public IComponent RemoveComponent(string componentType)
        {
            if (!this.components.Any(x => x.GetType().Name == componentType))
            {
                throw new ArgumentException
                (string.Format(ExceptionMessages.NotExistingComponent, componentType, this.GetType().Name, this.Id));
            }
            IComponent componentToRemove = components.First(x => x.GetType().Name == componentType);
            components.Remove(componentToRemove);
            return componentToRemove;
        }

        public void AddPeripheral(IPeripheral peripheral)
        {
            if (this.peripherals.Any(x => x.GetType() == peripheral.GetType()))
            {
                throw new ArgumentException
                    (string.Format(ExceptionMessages.ExistingPeripheral, peripheral.GetType().Name, this.GetType().Name, this.Id));
            }
            peripherals.Add(peripheral);
        }

        public IPeripheral RemovePeripheral(string peripheralType)
        {
            if (!this.peripherals.Any(x => x.GetType().Name == peripheralType))
            {
                throw new ArgumentException
                (string.Format(ExceptionMessages.NotExistingPeripheral, peripheralType, this.GetType().Name, this.Id));
            }
            IPeripheral peripheralToRemove = peripherals.First(x => x.GetType().Name == peripheralType);
            peripherals.Remove(peripheralToRemove);
            return peripheralToRemove;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Overall Performance: {this.OverallPerformance:f2}. Price: {this.Price:f2} - {this.GetType().Name}: {this.Manufacturer} {this.Model} (Id: {this.Id})"); // TODO 03:01:00
            sb.AppendLine($" Components ({this.Components.Count}):");
            foreach (var component in components)
            {
                sb.AppendLine($"  {component}");
            }
            if (peripherals.Count > 0)
            {
                sb.AppendLine($" Peripherals ({this.Peripherals.Count}); Average Overall Performance ({this.Peripherals.Average(x => x.OverallPerformance):f2}):");
                foreach (var peripheral in peripherals)
                {
                    sb.AppendLine($"  {peripheral}");
                }
            }
            else
            {
                sb.AppendLine(" Peripherals (0); Average Overall Performance (0.00):");
            }
            return sb.ToString().TrimEnd();
        }

        private double CaclcualteOverallPerformance()
        {
            if (this.Components.Count == 0)
            {
                return base.OverallPerformance;
            }
            var result = base.OverallPerformance + this.Components.Average(x => x.OverallPerformance);
            return result;
        }
    }
}
