namespace EasterRaces.Repositories.Entities
{
    using EasterRaces.Models.Races.Contracts;
    using EasterRaces.Repositories.Contracts;

    using System.Collections.Generic;
    using System.Linq;

    public class RaceRepository : IRepository<IRace>
    {
        private readonly ICollection<IRace> races;
        public RaceRepository()
        {
            this.races = new List<IRace>();
        }

        public void Add(IRace model)
        {
            races.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll() => this.races.ToList().AsReadOnly(); 

        public IRace GetByName(string name)
        
        {
            var race = races.FirstOrDefault(x => x.Name == name);
            return race;
        }

        public bool Remove(IRace model)
        {
            var raceToRemove = races.FirstOrDefault(x => x.Name == model.Name);
            if (raceToRemove == null)
            {
                return false;
            }
            races.Remove(raceToRemove);
            return true;
        }
    }
}
