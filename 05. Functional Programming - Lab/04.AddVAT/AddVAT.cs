namespace _04.AddVAT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AddVAT
    {
        public static void Main()
        {
            List<double> list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(x => x * 1.2).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"{item:F2}");
            }
        }
    }
}
