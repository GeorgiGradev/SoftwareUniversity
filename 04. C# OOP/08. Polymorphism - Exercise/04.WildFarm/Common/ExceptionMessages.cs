
using System;

namespace _04.WildFarm.Common
{
    public class UneatableFoodException : Exception
    {
        public UneatableFoodException(string message)
            :base(message)
        {

        }
    }
}
