namespace _05._Fashion_Boutique
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> boxWhitClothes = new Stack<int>(box);
            int capacityOfRack = int.Parse(Console.ReadLine());
            int saveCapacityOfRack = capacityOfRack;
            int countOfRacks = 1;

            while (boxWhitClothes.Count() > 0)
            {
                if (boxWhitClothes.Peek() < capacityOfRack)
                {
                    capacityOfRack -= boxWhitClothes.Pop();
                }
                else if (boxWhitClothes.Peek() == capacityOfRack)
                {
                    capacityOfRack -= boxWhitClothes.Pop();
                    if (boxWhitClothes.Count() > 0)
                    {
                        countOfRacks++;
                        capacityOfRack = saveCapacityOfRack;
                    }
                }
                else
                {
                    countOfRacks++;
                    capacityOfRack = saveCapacityOfRack;
                }
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
