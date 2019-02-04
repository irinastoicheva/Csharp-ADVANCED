namespace _07.SpeedRacing
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCar = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCar; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInformation[0];
                double fuelAmount = double.Parse(carInformation[1]);
                double fuelConsumptionFor1km = double.Parse(carInformation[2]);

                Car currentCar = new Car(model, fuelAmount, fuelConsumptionFor1km);

                cars.Add(currentCar);
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandLine[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Drive")
                {
                    string carModel = commandLine[1];
                    int amountOfKm = int.Parse(commandLine[2]);

                    Car currentCar = cars.Where(x => x.Model == carModel).FirstOrDefault();

                    currentCar.DriveCar(amountOfKm);
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount :F2} {car.DistanceTraveled}");
            }
        }
    }
}
