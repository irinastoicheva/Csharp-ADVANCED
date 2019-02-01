namespace CarManufacturer
{
    using System;
    using System.Text;

    public class Car
    {

        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car (string make, string model, int year, double fuelQuantity, double fuelConsumption) : this (make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }


        public void Drive(double distsance)
        {
            bool isContinue = this.FuelQuantity - (this.FuelConsumption / 100.0 * distsance) >= 0;

            if (isContinue)
            {
                this.FuelQuantity -= this.FuelConsumption / 100.0 * distsance;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder carInfo = new StringBuilder();
            carInfo.AppendLine($"Make: {this.Make}");
            carInfo.AppendLine($"Model: {this.Model}");
            carInfo.AppendLine($"Year: {this.Year}");
            carInfo.Append($"Fuel: {this.FuelQuantity:F2}L");

            return carInfo.ToString();
        }
    }
}
