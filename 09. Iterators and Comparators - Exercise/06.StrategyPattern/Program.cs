namespace _06.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> firstSet = new SortedSet<Person>(new ComparerPersonName());
            SortedSet<Person> secondSet = new SortedSet<Person>(new ComparerPersonAge());

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                firstSet.Add(person);
                secondSet.Add(person);
            }

            foreach (Person person in firstSet)
            {
                Console.WriteLine(person.ToString());
            }

            foreach (Person person in secondSet)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
