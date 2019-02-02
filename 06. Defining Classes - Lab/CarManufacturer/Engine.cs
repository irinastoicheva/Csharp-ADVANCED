namespace CarManufacturer
{
    using System;
    public class Engine
    {
        public Engine(int hoursePower, double cubicCapacity)
        {
            this.HorsePower = hoursePower;
            this.CubicCapacity = cubicCapacity;
        }

        private int hoursePower;
        private double cubicCapacity;

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }
}
