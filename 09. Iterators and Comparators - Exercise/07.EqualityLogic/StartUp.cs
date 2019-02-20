
namespace _07.EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> firstSet = new SortedSet<Person>();
            MyHashSet<Person> secondSet = new MyHashSet<Person>();

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

            Console.WriteLine(firstSet.Count);
            Console.WriteLine(secondSet.Count());
        }
    }
}
