using System.Collections.Generic;

namespace Repository
{
    public class Repository
    {
        private Dictionary<int, Person> list;

        public Repository()
        {
            this.list = new Dictionary<int, Person>();
        }


        public int Count { get; set; } = 0;
        public int Id { get; set; } = -1;

        public void Add(Person person)
        {
            list[++this.Id] = person;
            this.Count++;
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
                list[id] = newPerson;
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if (list.ContainsKey(id))
            {
                list.Remove(id);
                this.Count--;
                return true;
            }

            return false;
        }
    }
}
