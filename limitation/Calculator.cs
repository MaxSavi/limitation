using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace limitation
{
    public class Calculator<T> where T : IComparable<T>
    {
        public static T Add(T x, T y)
        {
            dynamic X = x;
            dynamic Y = y;
            return X + Y;
        }

        public static T Zero()
        {
            return default(T);
        }
    }
}
