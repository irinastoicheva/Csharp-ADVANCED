namespace _08.CustomComparator
{
    using System;
    using System.Linq;

    class CustomComparator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers);

            int[] num = numbers;

            Console.Write(string.Join(" ", numbers.Where(x => x % 2 == 0)) + " ");
            Console.WriteLine(string.Join(" ", num.Where(x => x % 2 != 0)));
        }
    }
}
