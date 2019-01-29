namespace _03._Periodic_Table
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            HashSet<string> list = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < line.Length; j++)
                {
                    list.Add(line[j]);
                }
            }

            Console.WriteLine(string.Join(" ", list.OrderBy(x => x)));
        }
    }
}
