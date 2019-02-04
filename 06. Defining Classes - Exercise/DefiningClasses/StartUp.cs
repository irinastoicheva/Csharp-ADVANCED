namespace DefiningClasses
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                Person person = new Person(input[0], int.Parse(input[1]));
                people.Add(person);
            }

            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
