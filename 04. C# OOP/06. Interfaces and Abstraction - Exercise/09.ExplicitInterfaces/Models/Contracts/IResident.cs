namespace Explicit_Interfaces.Models.Contracts
{
    public interface IResident
    {
        public string Name { get; }
        public string Country { get; }
        string GetName();
    }
}
