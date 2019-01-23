namespace _02._Average_Student_Grades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> list = new Dictionary<string, List<double>>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (!list.ContainsKey(name))
                {
                    list[name] = new List<double>();
                }

                list[name].Add(grade);
            }

            foreach (var kvp in list)
            {
                Console.Write($"{kvp.Key} -> ");
                Console.Write(string.Join(" ", kvp.Value.Select(x => string.Format($"{x:F2}"))));
                Console.WriteLine($" (avg: {kvp.Value.Average():F2})");
            }
        }
    }
}
