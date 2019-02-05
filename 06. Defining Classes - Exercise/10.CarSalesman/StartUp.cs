namespace _10.CarSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfEngine = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfEngine; i++)
            {
                string[] engineInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInformation[0];
                int power = int.Parse(engineInformation[1]);

                Engine engine;

                if (engineInformation.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (engineInformation.Length == 4)
                {
                    int displacement = int.Parse(engineInformation[2]);
                    string efficiency = engineInformation[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else
                {
                    bool isNumber = int.TryParse(engineInformation[2], out int displacement);

                    if (isNumber)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, engineInformation[2]);
                    }
                }

                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInformation[0];
                string engineModel = carInformation[1];
                Engine engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                Car car;

                if (carInformation.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (carInformation.Length == 4)
                {
                    double weight = double.Parse(carInformation[2]);
                    string color = carInformation[3];

                    car = new Car(model, engine, weight, color);
                }
                else
                {
                    bool isNumber = double.TryParse(carInformation[2], out double weight);

                    if (isNumber)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, carInformation[2]);
                    }
                }

                cars.Add(car);
            }

            foreach ( Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
