namespace _12.Google
{
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
        }


        public string Name { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon>();

        public List<Parent> Parents { get; set; } = new List<Parent>();

        public List<Child> Children { get; set; } = new List<Child>();

        public Car Car { get; set; }

        public void AddPokemon(Pokemon pokemon)
        {
            this.Pokemons.Add(pokemon);
        }

        public void AddParent(Parent parent)
        {
            this.Parents.Add(parent);
        }

        public void AddChild(Child child)
        {
            this.Children.Add(child);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine("Company:");
            if (this.Company != null)
            {
                sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");
            }

            sb.AppendLine("Car:");
            if (this.Car != null)
            {
                sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            sb.AppendLine("Pokemon:");
            if (this.Pokemons.Count > 0)
            {
                foreach (Pokemon pokemon in this.Pokemons)
                {
                    sb.AppendLine($"{pokemon.Name} {pokemon.Type}");
                }
            }

            sb.AppendLine("Parents:");
            if (this.Parents.Count > 0)
            {
                foreach (Parent parent in this.Parents)
                {
                    sb.AppendLine($"{parent.Name} {parent.Birthday}");
                }
            }

            if (this.Children.Count > 0)
            {
                sb.AppendLine("Children:");
                int countChildren = this.Children.Count;
                int count = 1;

                foreach (Child child in this.Children)
                {
                    if (count == countChildren)
                    {
                        sb.Append($"{child.Name} {child.Birthday}");
                    }
                    else
                    {
                        sb.AppendLine($"{child.Name} {child.Birthday}");
                    }
                }
            }
            else
            {
                sb.Append("Children:");
            }

            return sb.ToString();
        }
    }
}
