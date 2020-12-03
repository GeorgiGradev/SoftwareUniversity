namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Models.Cars.Contracts;
    using EasterRaces.Repositories.Contracts;

    using System.Collections.Generic;
    using System.Linq;

    public class CarRepository : IRepository<ICar>
    {
        private readonly ICollection<ICar> cars;
        public CarRepository()
        {
            this.cars = new List<ICar>();
        }

        public void Add(ICar model)
        {
           cars.Add(model);
        }

        public IReadOnlyCollection<ICar> GetAll() => this.cars.ToList().AsReadOnly(); 

        public ICar GetByName(string name)
        {
            var car = cars.FirstOrDefault(x => x.Model == name);
            return car;
        }

        public bool Remove(ICar model)
        {
            var carToRemove = cars.FirstOrDefault(x => x.Model == model.Model);
            if (carToRemove == null)
            {
                return false;
            }
            cars.Remove(carToRemove);
            return true;
        }
    }
}
