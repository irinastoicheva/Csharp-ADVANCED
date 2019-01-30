namespace _03.CountUppercaseWords
{
    using System;
    using System.Linq;

    class CountUppercaseWords
    {
        public static void Main()
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => char.IsUpper(x[0])).ToList().ForEach(Console.WriteLine);
        }
    }
}
