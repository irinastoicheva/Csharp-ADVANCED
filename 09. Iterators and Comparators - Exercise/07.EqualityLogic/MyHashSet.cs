
namespace _07.EqualityLogic
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class MyHashSet<Person> : IEnumerable<Person>
    {
        private SortedSet<Person> people;
        public MyHashSet()
        {
            this.people = new SortedSet<Person>();
        }

        public void Add(Person person)
        {
            people.Add(person);
        }

        public int Count()
        {
            return this.people.Count;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            foreach (var item in this.people)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
