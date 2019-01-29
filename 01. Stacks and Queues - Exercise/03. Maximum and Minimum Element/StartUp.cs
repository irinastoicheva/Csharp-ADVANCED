namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Stack<int> sequence = new Stack<int>();

            for (int i = 0; i < number; i++)
            {
                int[] commandLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = commandLine[0];

                if (command == 1)
                {
                    sequence.Push(commandLine[1]);
                }
                else if (command == 2)
                {
                    if (sequence.Count > 0)
                    {
                        sequence.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Max());
                    }
                }
                else if (command == 4)
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine(sequence.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
