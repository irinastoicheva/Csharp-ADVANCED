namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeOfHashSets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int lengthN = sizeOfHashSets[0];
            int lengthM = sizeOfHashSets[1];

            HashSet<int> hashSetN = new HashSet<int>();
            HashSet<int> hashSetM = new HashSet<int>();

            for (int i = 0; i < lengthN; i++)
            {
                hashSetN.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < lengthN; i++)
            {
                hashSetM.Add(int.Parse(Console.ReadLine()));
            }

            foreach (var item in hashSetN)
            {
                foreach (var number in hashSetM)
                {
                    if (item == number)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
