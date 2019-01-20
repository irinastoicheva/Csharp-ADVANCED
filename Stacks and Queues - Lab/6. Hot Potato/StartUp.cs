namespace _7._Hot_Potato
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> childrensNames = new Queue<string>(input);
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (childrensNames.Count() > 1)
            {
                if (counter % number == 0)
                {
                    Console.WriteLine($"Removed {childrensNames.Dequeue()}");
                }
                else
                {
                    string nameChild = childrensNames.Dequeue();
                    childrensNames.Enqueue(nameChild);
                }

                counter++;
            }

            Console.WriteLine($"Last is {childrensNames.Peek()}");
        }
    }
}
