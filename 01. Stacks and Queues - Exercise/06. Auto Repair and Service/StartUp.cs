namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> listOfCars = new Queue<string>(input);
            Stack<string> servedVehicles = new Stack<string>();
            string[] command = Console.ReadLine().Split('-');

            while (command[0] != "End")
            {
                if (command[0] == "Service" && listOfCars.Count() > 0)
                {
                    servedVehicles.Push(listOfCars.Dequeue());
                    Console.WriteLine($"Vehicle {servedVehicles.Peek()} got served.");
                }
                else if (command[0] == "CarInfo")
                {
                    if (listOfCars.Contains(command[1]))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command[0] == "History")
                {
                    Console.Write("");
                    Console.WriteLine(string.Join(", ", servedVehicles));
                }

                command = Console.ReadLine().Split('-');
            }

            if (listOfCars.Count() > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", listOfCars)}");
            }
            if (servedVehicles.Count() > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedVehicles)}");
            }
        }
    }
}
