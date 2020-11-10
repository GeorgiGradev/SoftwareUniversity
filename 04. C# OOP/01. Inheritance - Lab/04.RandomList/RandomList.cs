namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RandomList : List<string>
    {
        private Random rand;

        public RandomList(IEnumerable<string> collection)
            : base(collection)
        {
            rand = new Random();
        }

        public string RandomString()
        {
            string result = string.Empty;
            int index = rand.Next(0, this.Count);
            result = this[index];
            this.RemoveAt(index);

            return result;
        }
    }
}