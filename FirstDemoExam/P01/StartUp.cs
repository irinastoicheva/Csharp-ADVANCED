namespace P01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<int> leftSocks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> rightSocks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> pair = new List<int>();

            while (leftSocks.Count > 0 && rightSocks.Count > 0)
            {
                int leftSock = leftSocks.Last();
                int rightSock = rightSocks.First();

                if (leftSock > rightSock)
                {
                    pair.Add(leftSock + rightSock);
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                    rightSocks.RemoveAt(0);
                }
                else if (leftSock == rightSock)
                {
                    leftSocks[leftSocks.Count - 1] += 1;
                    rightSocks.RemoveAt(0);
                }
                else
                {
                    leftSocks.RemoveAt(leftSocks.Count - 1);
                }
            }

            Console.WriteLine(pair.Max());

            Console.WriteLine(string.Join(" ", pair));
        }
    }
}
