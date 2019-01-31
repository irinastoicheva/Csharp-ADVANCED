namespace _02.KnightsOfHonor
{
    using System;

    class KnightsOfHonor
    {
        public static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = n => Console.WriteLine($"Sir {n}");

            foreach (var item in names)
            {
                print(item);
            }
        }
    }
}
