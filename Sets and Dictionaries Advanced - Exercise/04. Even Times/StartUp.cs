namespace _04._Even_Times
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<int, int> listOfNumber = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!listOfNumber.ContainsKey(input))
                {
                    listOfNumber[input] = 0;
                }

                listOfNumber[input]++;
            }

            foreach (var item in listOfNumber)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
