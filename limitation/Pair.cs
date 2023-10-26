using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace limitation
{
    public class Pair<T, U> where T : class where U : class
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public void Swap()
        {
            T temp = First;
            First = Second as T;
            Second = temp as U; ;
        }
    }
}
