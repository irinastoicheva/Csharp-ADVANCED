namespace _04.TheKitchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Stack<int> knives = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> forks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> list = new List<int>();

            while (knives.Count > 0 && forks.Count > 0)
            {
                int knife = knives.Peek();
                int fork = forks.Peek();

                if (knife > fork)
                {
                    list.Add(knives.Pop() + forks.Dequeue());
                }

                else if (fork > knife)
                {
                    knives.Pop();
                }

                else
                {
                    forks.Dequeue();
                    int last = knives.Pop() + 1;
                    knives.Push(last);
                }
            }

            Console.WriteLine($"The biggest set is: {list.Max()}");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
