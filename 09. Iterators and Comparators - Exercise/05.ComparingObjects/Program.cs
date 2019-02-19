namespace _05.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                string name = commandLine[0];

                if (name == "END")
                {
                    break;
                }

                int age = int.Parse(commandLine[1]);
                string town = commandLine[2];

                Person person = new Person(name, age, town);
                people.Add(person);
            }

            int index = int.Parse(Console.ReadLine()) - 1;
            int[] statistic = new int[3];
            Person currentPerson = people[index];
            people.RemoveAt(index);
            int countEqualPeople = 0;
            int countNotEqual = 0;

            foreach (Person item in people)
            {
                if (item.CompareTo(currentPerson) == 0)
                {
                    countEqualPeople++;
                }
                else
                {
                    countNotEqual++;
                }
            }

            if (countEqualPeople == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            else
            {
                statistic[0] = countEqualPeople + 1;
                statistic[1] = countNotEqual;
                statistic[2] = people.Count + 1;
            }

            Console.WriteLine(string.Join(" ", statistic));
        }
    }
}
