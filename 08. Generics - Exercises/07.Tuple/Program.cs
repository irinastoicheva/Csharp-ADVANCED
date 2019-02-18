namespace _07.Tuple
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
            Tuple<string, string> tuple = new Tuple<string, string>(name, address);

            string[] secondInput = Console.ReadLine().Split();
            name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(name, litersOfBeer);

            string[] thirdInput = Console.ReadLine().Split();
            int numberInteger = int.Parse(thirdInput[0]);
            double numberDouble = double.Parse(thirdInput[1]);
            Tuple<int, double> tuple3 = new Tuple<int, double>(numberInteger, numberDouble);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);


        }
    }
}
