namespace CollectionHierarchy.Models
{
    public class AddCollection : CustomCollections
    {
        public AddCollection()
            : base()
        {

        }

        public override int Add(string element)
        {
            this.Collection.Add(element);

            return this.Collection.Count - 1;
        }
    }
}
