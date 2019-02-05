namespace _09.RectangleIntersection
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int numberOfRectangle = input[0];
            int numberOfIntersectionChecks = input[1];

            for (int i = 0; i < numberOfRectangle; i++)
            {

            }
        }
    }
}
