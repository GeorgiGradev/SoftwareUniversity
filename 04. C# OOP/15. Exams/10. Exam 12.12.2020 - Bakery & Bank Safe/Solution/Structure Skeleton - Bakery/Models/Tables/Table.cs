namespace Bakery.Models.Tables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Bakery.Models.BakedFoods.Contracts;
    using Bakery.Models.Drinks.Contracts;
    using Bakery.Models.Tables.Contracts;
    using Bakery.Utilities.Messages;

    public abstract class Table : ITable
    {
        private IList<IBakedFood> foodOrders;
        private IList<IDrink> drinkOrders;

        private int capacity;
        private int numberOfPeople;

        protected Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            TableNumber = tableNumber;
            Capacity = capacity;
            PricePerPerson = pricePerPerson;
            foodOrders = new List<IBakedFood>();
            drinkOrders = new List<IDrink>();
        }

        public IReadOnlyCollection<IBakedFood> BakedFoods => foodOrders.ToList();
        public IReadOnlyCollection<IDrink> DrinkOrders => drinkOrders.ToList();
        public int TableNumber { get; }
        public int Capacity
        {
            get => this.capacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }
                this.capacity = value;
            }
        }

        public int NumberOfPeople
        {
            get => this.numberOfPeople;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }
                this.numberOfPeople = value;
            }
        }
        public decimal PricePerPerson { get; }
        public bool IsReserved { get; protected set;  } // TODO Check initial state (false or true) if needed
        public decimal Price { get; }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.IsReserved = true;
        }
        public void OrderFood(IBakedFood food)
        {
            foodOrders.Add(food);
        }
        public void OrderDrink(IDrink drink)
        {
            drinkOrders.Add(drink);
        }
        public virtual decimal GetBill()
        {
            var totalBill = (foodOrders.Select(x => x.Price).Sum()
                + drinkOrders.Select(x => x.Price).Sum());
            return totalBill;
        }
        public void Clear()  // TODO Check this if final table calculations are wrong
        {
            this.foodOrders.Clear();
            this.drinkOrders.Clear();
            this.IsReserved = false;
            this.numberOfPeople = 0;
        }
        public string GetFreeTableInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson:F2}");
  
            return sb.ToString().TrimEnd();
        }
    }
}