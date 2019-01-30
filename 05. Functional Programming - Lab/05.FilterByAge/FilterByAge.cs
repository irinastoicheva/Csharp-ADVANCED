namespace _05.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class FilterByAge
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<Person> listOfPeople = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] currentPerson = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = currentPerson[0];
                int age = int.Parse(currentPerson[1]);

                Person person = new Person()
                {
                    Name = name,
                    Age = age
                };

                listOfPeople.Add(person);
            }

            string condition = Console.ReadLine();
            int sortAge = int.Parse(Console.ReadLine());

            Func<Person, bool> funcPredicate;

            if (condition == "older")
            {
                funcPredicate = p => p.Age >= sortAge;
            }
            else
            {
                funcPredicate = p => p.Age < sortAge;
            }

            string printFormat = Console.ReadLine();

            Func<Person, string> funcPrint;

            if (printFormat == "name age")
            {
                funcPrint = p => $"{p.Name} - {p.Age}";
            }
            else
            {
                funcPrint = p => $"{p.Name}";
            }

            listOfPeople.Where(funcPredicate).Select(funcPrint).ToList().ForEach(Console.WriteLine);
        }
    }
}
