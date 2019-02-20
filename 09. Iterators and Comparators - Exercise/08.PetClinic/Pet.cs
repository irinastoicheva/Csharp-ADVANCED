using System;

namespace _08.PetClinic
{
    public class Pet :IComparable<Pet>
    {
        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.Age = age;
            this.Kind = kind;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }

        public int CompareTo(Pet other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
