using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICallable, ISmartable
    {
        public string Call(string number)
        {
            return $"Calling... {number}";
        }
        public string Browse(string website)
        {
            return $"Browsing: {website}!";
        }
    }
}
