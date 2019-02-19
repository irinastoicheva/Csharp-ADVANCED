namespace _03.Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> list;
        private int count;
        public CustomStack()
        {
            this.list = new List<T>();
            this.count = this.list.Count;
        }

        public void Push(params T[] input)
        {
            this.list.AddRange(input);
        }

        public void Pop()
        {
            if (this.list.Count <= 0)
            {
                throw new InvalidOperationException("No elements");
            }

            int lastIndex = this.list.Count - 1;
                this.list.RemoveAt(lastIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.list.Count - 1; i >= 0; i--)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
