using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> route;
        public Lake(params int [] input)
        {
            this.route = input.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.route.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.route[i];
                }
            }

            for (int i = this.route.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return this.route[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
