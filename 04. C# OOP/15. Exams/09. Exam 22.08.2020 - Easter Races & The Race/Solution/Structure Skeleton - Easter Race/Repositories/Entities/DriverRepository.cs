namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Models.Drivers.Contracts;
    using EasterRaces.Repositories.Contracts;

    using System.Collections.Generic;
    using System.Linq;

    public class DriverRepository : IRepository<IDriver>
    {
        private readonly ICollection<IDriver> drivers;
        public DriverRepository()
        {
            this.drivers = new List<IDriver>();
        }

        public bool Any { get; internal set; }

        public void Add(IDriver model)
        {
            drivers.Add(model);
        }

        public IReadOnlyCollection<IDriver> GetAll() => this.drivers.ToList().AsReadOnly(); 

        public IDriver GetByName(string name)
        {
            var driver = drivers.FirstOrDefault(x => x.Name == name);
            return driver;
        }

        public bool Remove(IDriver model)
        {
            var driverToRemove = drivers.FirstOrDefault(x => x.Name == model.Name);
            if (driverToRemove == null)
            {
                return false;
            }
            drivers.Remove(driverToRemove);
            return true;
        }
    }
}
