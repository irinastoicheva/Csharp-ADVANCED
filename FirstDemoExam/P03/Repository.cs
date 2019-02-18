using System.Collections.Generic;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> list;
        private int id;

        public Repository()
        {
            this.list = new Dictionary<int, Person>();
            this.id = 0;
        }

        public int Count => this.list.Count;

        public void Add(Person person)
        {
            list[this.id++] = person;
        }

        public Person Get(int id)
        {
            Person person = this.list[id];
            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            if (list.ContainsKey(id))
            {
                this.list[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (list.ContainsKey(id))
            {
                this.list.Remove(id);
                return true;
            }

            return false;
        }
    }
}
