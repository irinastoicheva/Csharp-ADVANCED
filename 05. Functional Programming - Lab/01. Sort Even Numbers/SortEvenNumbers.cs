namespace _01._Sort_Even_Numbers
{
    using System;
    using System.Linq;

    class SortEvenNumbers
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ", sequence.OrderBy(x=>x)));
        }
    }
}
