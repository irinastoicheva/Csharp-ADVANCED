namespace _07.PredicateForNames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class PredicateForNames
    {
       public static void Main()
        {
            int length = int.Parse(Console.ReadLine());

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length <= length)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
