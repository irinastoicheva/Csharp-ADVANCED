namespace _8._Traffic_Jam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            int numbersOfCarsPassingOnGreen = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    int numberOfCarsPassed = Math.Min(cars.Count(), numbersOfCarsPassingOnGreen);
                    counter += numberOfCarsPassed;

                    for (int i = 0; i < numberOfCarsPassed; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
