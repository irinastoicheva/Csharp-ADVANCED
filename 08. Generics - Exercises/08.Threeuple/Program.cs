namespace _08.Threeuple
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string name = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];
            Threeuple<string, string, string> tuple = new Threeuple<string, string, string>(name, address, town);

            string[] secondInput = Console.ReadLine().Split();
            name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            bool isDrink = false;
            if (secondInput[2] == "drunk")
            {
                isDrink = true;
            }
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(name, litersOfBeer, isDrink);

            string[] thirdInput = Console.ReadLine().Split();
            name = thirdInput[0];
            double numberDouble = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(name, numberDouble, bankName);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);


        }
    }
}
