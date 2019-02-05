namespace _12.Google
{
    using System;

    public class Child
    {
        public Child(string name, string birthDay)
        {
            this.Name = name;
            this.Birthday = birthDay;
        }
        public string Name { get; set; }

        public string Birthday { get; set; }
    }
}
