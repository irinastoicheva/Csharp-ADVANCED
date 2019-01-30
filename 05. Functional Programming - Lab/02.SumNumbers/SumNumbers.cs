namespace _02.SumNumbers
{
    using System;
    using System.Linq;

    class SumNumbers
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(sequence.Count());
            Console.WriteLine(sequence.Sum());
        }
    }
}
