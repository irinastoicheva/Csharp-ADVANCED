namespace _05.AppliedArithmetics
{
    using System;
    using System.Linq;

    class AppliedArithmetics
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Func<int, int> funcAdd = n => n + 1;
            Func<int, int> funcMultiply = n => n * 2;
            Func<int, int> funcSubtract = n => n - 1;
            Action<int[]> print = n => Console.WriteLine(string.Join(" ", n));

            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = numbers.Select(funcAdd).ToArray();
                        break;
                    case "multiply":
                        numbers = numbers.Select(funcMultiply).ToArray();
                        break;
                    case "subtract":
                        numbers = numbers.Select(funcSubtract).ToArray();
                        break;
                    case "print":
                        print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
