using System.Collections.Generic;

namespace BoxOfT
{
    using System;
    public class Box<T>
    {
        public int Count { get; set; }

        Stack<T> list = new Stack<T>();

        public void Add(T element)
        {
            list.Push(element);
            this.Count++;
        }

        public T Remove()
        {
            this.Count--;
            return list.Pop();
        }
    }
}
