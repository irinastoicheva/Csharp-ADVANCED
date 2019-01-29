namespace _06._Parking_Lot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            HashSet<string> listOfCar = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] line = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = line[0];
                string regNumberCar = line[1];

                if (command == "IN")
                {
                    listOfCar.Add(regNumberCar);
                }
                else if (command == "OUT")
                {
                    if (listOfCar.Contains(regNumberCar))
                    {
                        listOfCar.Remove(regNumberCar);
                    }
                }
            }

            if (listOfCar.Count > 0)
            {
                foreach (var item in listOfCar)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
