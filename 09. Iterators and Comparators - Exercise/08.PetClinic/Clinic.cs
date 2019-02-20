using System;
using System.Collections.Generic;

namespace _08.PetClinic
{
    public class Clinic : IComparable<Clinic>
    {
        public Clinic(string name, int rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
        }
        public string Name { get; set; }
        public int Rooms { get; set; }

        public int CompareTo(Clinic other)
        {
           return this.Name.CompareTo(other.Name);
        }
    }
}
