namespace _02.Collection
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        private int currentIndex = 0;
        public ListyIterator(params T[] list)
        {
            this.list = new List<T>(list);
        }

        public bool Move()
        {
            if (this.currentIndex < this.list.Count - 1)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex < this.list.Count - 1)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.currentIndex <= this.list.Count - 1)
            {
                return $"{this.list[this.currentIndex]}";
            }

            return "Invalid Operation!";
        }

        public string PrintAll()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.list.Count; i++)
            {
                if (i != this.list.Count - 1)
                {
                    sb.Append(this.list[i].ToString() + " ");
                }
                else
                {
                    sb.Append(this.list[i].ToString());
                }
            }

            return sb.ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
