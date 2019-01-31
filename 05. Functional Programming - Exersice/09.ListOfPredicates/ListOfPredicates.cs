namespace _09.ListOfPredicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ListOfPredicates
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> cequence = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                cequence.Add(i);
            }

            for (int i = 0; i < input.Length; i++)
            {
                cequence = cequence.Where(x => x % input[i] == 0).ToList();
            }

            Console.WriteLine(string.Join(" ", cequence));
        }
    }
}
