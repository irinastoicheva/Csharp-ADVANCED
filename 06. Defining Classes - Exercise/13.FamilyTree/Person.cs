namespace _13.FamilyTree
{
    using System.Collections.Generic;

    public class Person
    {
        public Person(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
            this.Perents = new List<string>();
            this.Children = new List<string>();
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public List<string> Perents { get; set; } = new List<string>();

        public List<string> Children { get; set; } = new List<string>();
    }
}
