namespace CounterStrike.Repositories
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CounterStrike.Models.Players.Contracts;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;

    public class PlayerRepository : IRepository<IPlayer>
    {
        private ICollection<IPlayer> models;
        public PlayerRepository()
        {
            this.models = new List<IPlayer>();
        }

        public IReadOnlyCollection<IPlayer> Models => this.models.ToList().AsReadOnly();
        // TODO Try it without .AsReadOnly and also with auto property with only getter

        public void Add(IPlayer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidPlayerRepository);
            }
            models.Add(model);
        }
        public bool Remove(IPlayer model)
        {
            return this.models.Remove(model);
        }
        public IPlayer FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Username == name);
        }

    }
}
