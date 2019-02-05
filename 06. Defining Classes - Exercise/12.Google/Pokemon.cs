namespace _12.Google
{
    using System;
    public class Pokemon
    {
        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
