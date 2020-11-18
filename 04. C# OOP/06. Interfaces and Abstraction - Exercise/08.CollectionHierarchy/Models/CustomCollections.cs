using CollectionHierarchy.Contracts;
using System.Collections.Generic;

namespace CollectionHierarchy.Models
{
    public abstract class CustomCollections : IAdd
    {
        private ICollection<string> collection;

        public CustomCollections()
        {
            this.collection = new List<string>();
        }

        protected IList<string> Collection
        {
            get
            {
                return (IList<string>)this.collection;
            }
        }

        public abstract int Add(string element);
    }
}
