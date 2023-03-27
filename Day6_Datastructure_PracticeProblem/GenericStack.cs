using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Datastructure_PracticeProblem
{
    public class GenericStack<T>
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
                throw new InvalidOperationException("The stack is empty.");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return items[items.Count - 1];
        }

        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        public void Clear()
        {
            items.Clear();
        }
    }
}

