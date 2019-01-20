namespace _6._Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Queue<string> queueOfNames = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queueOfNames.Count() > 0)
                    {
                        Console.WriteLine(queueOfNames.Dequeue());
                    }
                }
                else
                {
                    queueOfNames.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{queueOfNames.Count} people remaining.");
        }
    }
}
