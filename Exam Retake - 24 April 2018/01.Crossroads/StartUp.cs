namespace _01.Crossroads
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            Stack<string> carsPassedTheCrossroads = new Stack<string>();
            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int currentGreenLight = greenLight;
                    while (currentGreenLight > 0 && cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        carsPassedTheCrossroads.Push(car);
                        currentGreenLight -= car.Length;
                    }

                    if (freeWindow + currentGreenLight < 0)
                    {
                        Console.WriteLine("A crash happened!");
                        string car = carsPassedTheCrossroads.Pop();
                        Console.WriteLine($"{car} was hit at {car[car.Length + currentGreenLight + freeWindow]}.");
                        return;
                    }

                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsPassedTheCrossroads.Count} total cars passed the crossroads.");
        }
    }
}
