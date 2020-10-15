using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace _03.Stack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> elements;
        private int currentIndex = 0;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                elements.Insert(currentIndex, item);
                currentIndex++;
            }
        }

        public void Pop()
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                throw new InvalidOperationException("No elements");
            }
            elements.RemoveAt(elements.Count - 1);

        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = currentIndex - 1; i >= 0; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
