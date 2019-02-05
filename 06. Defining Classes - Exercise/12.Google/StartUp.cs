namespace _12.Google
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] information = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = information[0];

                if (!people.Any(x => x.Name == name))
                {
                    Person newPerson = new Person(name);
                    people.Add(newPerson);
                }

                string informationFor = information[1];

                Person person = people.FirstOrDefault(x => x.Name == name);

                switch (informationFor)
                {
                    case "company":
                        string companyName = information[2];
                        string department = information[3];
                        double salary = double.Parse(information[4]);

                        Company company = new Company(companyName, department, salary);
                        person.Company = company;
                        break;

                    case "car":
                        string model = information[2];
                        int speed = int.Parse(information[3]);

                        Car car = new Car(model, speed);
                        person.Car = car;
                        break;

                    case "pokemon":
                        string pokemonName = information[2];
                        string type = information[3];

                        Pokemon pokemon = new Pokemon(pokemonName, type);
                        person.AddPokemon(pokemon);
                        break;

                    case "parents":
                        string parentName = information[2];
                        string birthday = information[3];

                        Parent parent = new Parent(parentName, birthday);
                        person.AddParent(parent);
                        break;

                    case "children":
                        string childName = information[2];
                        string childBirthday = information[3];

                        Child child = new Child(childName, childBirthday);
                        person.AddChild(child);
                        break;
                }
            }

            string personName = Console.ReadLine();
            Person currentPerson = people.Where(x => x.Name == personName).FirstOrDefault();
            Console.WriteLine(currentPerson);
        }
    }
}
