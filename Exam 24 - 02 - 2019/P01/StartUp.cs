
namespace P01
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> input =new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            Queue<string> halls = new Queue<string>();
            Queue<int> people = new Queue<int>();
            while (input.Count > 0)
            {
                string currentElement = input.Pop();
                int result;
                bool isNumber = int.TryParse(currentElement, out result);
                if (isNumber && halls.Count > 0)
                {
                    people.Enqueue(result);
                }
                else if (!isNumber)
                {
                    halls.Enqueue(currentElement);
                }
            }

            int sumPeople = 0;
            List<int> list = new List<int>();
            while (halls.Count > 0 && people.Count > 0)
            {
                int currentPeople = people.Peek();
                if (currentPeople > capacity)
                {
                    break;
                }
                if (sumPeople + currentPeople < capacity)
                {
                        list.Add(currentPeople);
                        sumPeople += people.Dequeue();
                }
                else if (sumPeople + currentPeople == capacity)
                {
                    list.Add(currentPeople);
                    sumPeople += people.Dequeue();
                    Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", list)}");
                    sumPeople = 0;
                    list.Clear();
                }
                else if (sumPeople + currentPeople > capacity && halls.Count > 1)
                {
                    Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", list)}");
                    sumPeople = 0;
                    list.Clear();
                }
                else
                {
                    break;
                }
            }

            if (halls.Count == 0 && list.Count > 0)
            {
                Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", list)}");
            }

        }
    }
}
