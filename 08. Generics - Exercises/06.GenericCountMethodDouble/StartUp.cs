namespace _06.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < number; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double element = double.Parse(Console.ReadLine());
            int counter = GetCountOfTheElementsThatAreGreater(box.Data, element);
            Console.WriteLine(counter);
        }

        public static int GetCountOfTheElementsThatAreGreater<T>(List<T> list, T element) where T : IComparable
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }


            return counter;
        }
    }
}
