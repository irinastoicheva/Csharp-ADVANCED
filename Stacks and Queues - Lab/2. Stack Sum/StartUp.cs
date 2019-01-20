namespace _2._Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackOfNUmbers = new Stack<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                stackOfNUmbers.Push(numbers[i]);
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().ToLower().Split();
                string command = commandLine[0];
                if (command == "end")
                {
                    break;
                }
                if (command == "add")
                {
                    int firstNumber = int.Parse(commandLine[1]);
                    int secondNumber = int.Parse(commandLine[2]);
                    stackOfNUmbers.Push(firstNumber);
                    stackOfNUmbers.Push(secondNumber);
                }
                else if (command == "remove")
                {
                    int number = int.Parse(commandLine[1]);

                    if (number <= stackOfNUmbers.Count())
                    {
                        for (int i = 0; i < number; i++)
                        {
                            stackOfNUmbers.Pop();
                        }
                    }
                }
            }

            stackOfNUmbers.ToArray();
            Console.WriteLine($"Sum: {stackOfNUmbers.Sum()}");
        }
    }
}
