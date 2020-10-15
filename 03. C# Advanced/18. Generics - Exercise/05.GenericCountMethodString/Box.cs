using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable
    {

        public int CountGreaterElements(List<T> elememts, T elementToCompare)
        {
            int counter = 0;
            foreach (var element in elememts)
            {

                if (elementToCompare.CompareTo(element) < 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
