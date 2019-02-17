namespace _05.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();
            Box<string> box = new Box<string>();
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                box.Add(input);
            }

            string element = Console.ReadLine();
            int count = GetCountOfTheElementsThatAreGreater<string>(box.Data, element);

            Console.WriteLine(count);

        }

        public static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count > firstIndex && firstIndex >= 0 && list.Count > secondIndex && secondIndex >= 0)
            {
                var temp = list[firstIndex];
                list[firstIndex] = list[secondIndex];
                list[secondIndex] = temp;
            }
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
