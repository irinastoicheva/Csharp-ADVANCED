namespace _01._Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countOfNumbersForInput = Math.Min(commands[0], numbers.Length);
            int countOfNumbersForDelete = commands[1];
            int number = commands[2];
            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < countOfNumbersForInput; i++)
            {
                stackOfNumbers.Push(numbers[i]);
            }

            int countForDelete = Math.Min(countOfNumbersForDelete, stackOfNumbers.Count());
            for (int i = 0; i < countForDelete; i++)
            {
                stackOfNumbers.Pop();
            }

            if (stackOfNumbers.Contains(number))
            {
                Console.WriteLine("true");
            }
            else if (stackOfNumbers.Count() == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stackOfNumbers.ToList().Min());
            }
        }
    }
}
