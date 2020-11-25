namespace SantaWorkshop.Repositories
{
    using SantaWorkshop.Models.Dwarfs.Contracts;
    using SantaWorkshop.Repositories.Contracts;
    using System.Collections.Generic;
    using System.Linq;

    public class DwarfRepository : IRepository<IDwarf>
    {
        private readonly List<IDwarf> models;

        public DwarfRepository()
        {
            this.models = new List<IDwarf>(); 
        }

        public IReadOnlyCollection<IDwarf> Models => this.models.AsReadOnly();

        public object FirstOrDefault { get; internal set; }

        public void Add(IDwarf model)
        {
            this.models.Add(model) ;
        } 
        public bool Remove(IDwarf dwarf)
        {
            return this.models.Remove(dwarf);
        }

        public IDwarf FindByName(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
        }
    }
}
