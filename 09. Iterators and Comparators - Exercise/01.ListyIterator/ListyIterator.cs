namespace _01.ListyIterator
{
    using System.Collections.Generic;

    public class ListyIterator
    {
        private List<string> list;
        private int currentIndex = 0;
        public ListyIterator(params string [] list)
        {
            this.list = new List<string>(list);
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
    }
}
