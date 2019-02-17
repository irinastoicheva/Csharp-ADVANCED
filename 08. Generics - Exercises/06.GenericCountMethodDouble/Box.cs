using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public List<T> Data => this.data;

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.data)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString();
        }
    }
}
