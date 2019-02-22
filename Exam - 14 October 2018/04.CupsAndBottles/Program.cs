namespace _04.CupsAndBottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wastedLittersOfWater = 0;

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cup = cups.Dequeue();
                while (cup > 0)
                {
                    int bottle = bottles.Pop();
                    cup -= bottle;
                }

                wastedLittersOfWater += Math.Abs(cup);
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }
    }
}
