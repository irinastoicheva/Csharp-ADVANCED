namespace _07.SpeedRacing
{
    using System;

    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionFor1km;
        private int distanceTraveled;
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1km = fuelConsumptionFor1km;
            this.DistanceTraveled = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionFor1km { get; set; }

        public double DistanceTraveled { get; set; }


        public void DriveCar(int amountOfKm)
        {
            if (this.FuelAmount - (this.FuelConsumptionFor1km * amountOfKm) >= 0)
            {
                this.FuelAmount -= this.FuelConsumptionFor1km * amountOfKm;
                this.DistanceTraveled += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
