using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> elements;
        private int index;

        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                this.index ++;
            }
            return hasNext;
        }

        public bool HasNext()
        {
            if (this.index < this.elements.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (elements.Count > 0)
            {
                Console.WriteLine(this.elements[this.index]);
            }
            else
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
        }
    }
}
