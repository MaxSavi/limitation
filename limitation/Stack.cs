using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace limitation
{
    public class Stack<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек пустой");
            }

            int lastIndex = items.Count - 1;
            T item = items[lastIndex];
            items.RemoveAt(lastIndex);
            return item;
        }

        public T Max()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Стек пустой");
            }

            T max = items[0];

            foreach (T item in items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public int Count
        {
            get { return items.Count; }
        }
    }

    

}
