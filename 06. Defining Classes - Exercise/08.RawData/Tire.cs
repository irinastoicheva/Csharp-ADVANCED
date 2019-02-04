namespace _08.RawData
{
    using System;

    public class Tire
    {
        public Tire(double tirePressure, int age)
        {
            this.TirePressure = tirePressure;
            this.Age = age;
        }

        public double TirePressure { get; set; }

        public int Age { get; set; }
    }
}
