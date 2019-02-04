namespace _05.DateModifier
{
    using System;
    using System.Globalization;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] inputFirstData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime firstDate = new DateTime (inputFirstData[0], inputFirstData[1], inputFirstData[2]);

            int[] inputSecondData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime secondDate = new DateTime(inputSecondData[0], inputSecondData[1], inputSecondData[2]);

            DateModifier dateModifier = new DateModifier(firstDate, secondDate);

            Console.WriteLine(dateModifier.GetDifference());
        }
    }
}
