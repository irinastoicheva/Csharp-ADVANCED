namespace _06.ReverseAndExclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseAndExclude
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers.Where(x => x % number != 0)));
        }
    }
}
