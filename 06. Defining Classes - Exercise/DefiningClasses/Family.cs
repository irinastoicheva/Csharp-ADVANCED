namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Family
    {
        private List<Person> people = new List<Person>();

        public void AddMember(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = this.people.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;
        }
    }
}
