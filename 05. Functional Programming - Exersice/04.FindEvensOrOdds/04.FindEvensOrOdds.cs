namespace _04.FindEvensOrOdds
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            int[] bound = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int, int[]> funcGetNumbers = GetNumbers;

            int[] sequence = funcGetNumbers(bound[0], bound[1]);

            string typeNumbers = Console.ReadLine();

            Func<int, bool> funcEven = n => n % 2 == 0;

            Func<int, bool> funcOdd = n => n % 2 != 0;

            if (typeNumbers == "even")
            {
                Console.WriteLine(string.Join(" ", sequence.Where(funcEven)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", sequence.Where(funcOdd)));
            }
        }
        
        public static int[] GetNumbers(int x, int y)
        {
            int[] numbers = new int[y - x + 1];
            int end = y - x;
            for (int i = 0; i <= end; i++)
            {
                numbers[i] = x;
                x++;
            }
            return numbers;
        }
    }
}
