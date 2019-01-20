namespace _5_Print_Even_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> queueOfNumbers = new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    queueOfNumbers.Enqueue(numbers[i]);
                }
            }

            while (queueOfNumbers.Count > 1)
            {
                Console.Write(queueOfNumbers.Dequeue());
                Console.Write(", ");
            }
            Console.Write(queueOfNumbers.Dequeue());
            Console.WriteLine();
        }
    }
}
