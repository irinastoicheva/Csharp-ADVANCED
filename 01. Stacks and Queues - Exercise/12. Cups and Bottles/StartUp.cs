namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] cupsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(cupsInput);
            int[] bottlesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bottles = new Stack<int>(bottlesInput);

            int sum = 0;
            
            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();
                int currentBotlle = bottles.Peek();

                if (currentBotlle >= currentCup)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    sum += currentBotlle - currentCup;
                }
                else
                {
                    while (currentCup > 0)
                    {
                        currentBotlle = bottles.Peek();

                        if (currentCup > currentBotlle)
                        {
                            currentCup -= currentBotlle;
                            bottles.Pop();
                        }
                        else if (currentCup == currentBotlle)
                        {
                            currentCup = 0;
                            cups.Dequeue();
                            bottles.Pop();
                        }
                        else
                        {
                            currentCup -= currentBotlle;
                            cups.Dequeue();
                            bottles.Pop();
                            sum += Math.Abs(currentCup);
                        }
                    }
                }
            }

            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {sum}");

        }
    }
}
