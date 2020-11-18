using CollectionHierarchy.Contracts;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : AddCollection, IRemove
    {
        public AddRemoveCollection()
            : base()
        {

        }

        public override int Add(string element)
        {
            this.Collection.Insert(0, element);

            return 0;
        }

        public virtual string Remove()
        {
            string element = this.Collection[this.Collection.Count - 1];
            this.Collection.RemoveAt(this.Collection.Count - 1);

            return element;
        }
    }
}
