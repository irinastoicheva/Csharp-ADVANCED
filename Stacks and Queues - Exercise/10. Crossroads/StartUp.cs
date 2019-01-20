namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int durationOfTheGreenLight = int.Parse(Console.ReadLine());
            int durationOfTheFreeWindow = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int remainingTimeFromTheGreenLight = 0;

            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (command != "END")
            {
                if (command == "green")
                {
                    remainingTimeFromTheGreenLight = durationOfTheGreenLight;

                    while (cars.Any() && remainingTimeFromTheGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();
                        counter++;

                        if (remainingTimeFromTheGreenLight > currentCar.Length)
                        {
                            remainingTimeFromTheGreenLight -= currentCar.Length;
                        }
                        else if (remainingTimeFromTheGreenLight == currentCar.Length)
                        {
                            remainingTimeFromTheGreenLight = 0;
                            break;
                        }
                        else
                        {
                            if (remainingTimeFromTheGreenLight + durationOfTheFreeWindow >= currentCar.Length)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                int index = Math.Abs(remainingTimeFromTheGreenLight + durationOfTheFreeWindow - currentCar.Length);
                                Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length-index]}.");
                                return;
                            }
                        }
                    }
                    remainingTimeFromTheGreenLight = 0;
                }
                else
                {
                    cars.Enqueue(command);
                    if (remainingTimeFromTheGreenLight > 0)
                    {
                        string currentCar = cars.Dequeue();
                        counter++;

                        if (remainingTimeFromTheGreenLight > currentCar.Length)
                        {
                            remainingTimeFromTheGreenLight -= currentCar.Length;
                        }
                        else if (remainingTimeFromTheGreenLight == currentCar.Length)
                        {
                            break;
                        }
                        else
                        {
                            if (remainingTimeFromTheGreenLight + durationOfTheFreeWindow >= currentCar.Length)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("A crash happened!");
                                int index = Math.Abs(remainingTimeFromTheGreenLight + durationOfTheFreeWindow - currentCar.Length);
                                Console.WriteLine($"{currentCar} was hit at {currentCar[currentCar.Length - index]}.");
                                return;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
