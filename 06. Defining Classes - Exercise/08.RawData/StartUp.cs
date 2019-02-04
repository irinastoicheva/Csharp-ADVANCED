namespace _08.RawData
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int numberOfCar = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCar; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInformation[0];

                int engineSpeed = int.Parse(carInformation[1]);
                int enginePower = int.Parse(carInformation[2]);
                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInformation[3]);
                string cargoType = carInformation[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Tire[] tires = new Tire[4];
                for (int j = 0; j < tires.Length; j++)
                {
                    double tirePressure = double.Parse(carInformation[5 + 2 * j]);
                    int tireAge = int.Parse(carInformation[6 + 2 * j]);

                    Tire tire = new Tire(tirePressure, tireAge);
                    tires[j] = tire;
                }

                Car currenCar = new Car(model, engine, cargo, tires);
                cars.Add(currenCar);
            }

            string typeCargo = Console.ReadLine();

            if (typeCargo == "fragile")
            {
                foreach (Car car in cars.Where(x => x.Cargo.CargoType == typeCargo).Where(x => x.Tires.Any(t => t.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (Car car in cars.Where(x => x.Cargo.CargoType == typeCargo).Where(x => x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
