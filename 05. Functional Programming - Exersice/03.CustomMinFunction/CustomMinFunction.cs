namespace _03.CustomMinFunction
{
    using System;
    using System.Linq;

    class CustomMinFunction
    {
        public static void Main()
        {
            Func<int[], int> customMinFunction = n => n.Min();

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(customMinFunction(numbers));
        }
    }
}
