using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class RandomList : ArrayList
    {
        Random r = new Random();
        public object? RandomObject()
        {
            if (Count == 0) return null;
            int index = r.Next(0, Count);
            var tmp = this[index];
            RemoveAt(index);
            return tmp;
        }
    }
}
