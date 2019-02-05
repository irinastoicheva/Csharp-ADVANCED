namespace _10.CarSalesman
{
    using System;
    using System.Text;

    public class Car
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;

        public Car(string model, Engine engine, double weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, double weight) : this (model, engine, weight, DefaultValueString)
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, DefaultValueInt, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, DefaultValueInt, DefaultValueString)
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");

            if (this.Engine.Displacement == - 1)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
            }

            sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");

            if (this.Weight == - 1)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }

            sb.Append($"  Color: {this.Color}");

            return sb.ToString();
        }
    }
}
