namespace CounterStrike.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;

    public class GunRepository : IRepository<IGun>
    {
        private readonly ICollection<IGun> guns;

        public GunRepository()
        {
            this.guns = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models => this.guns.ToList().AsReadOnly();
        // TODO Try it without .AsReadOnly and also with Auto property with only getter

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }
            guns.Add(model);
        }

        public bool Remove(IGun model)
        {
            return this.guns.Remove(model);
        }

        public IGun FindByName(string name)
        {
            return this.guns.FirstOrDefault(x => x.Name == name);
        }

    }
}
