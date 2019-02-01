namespace _13.TriFunction
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class TriFunction
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<string> words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Func<string, int, bool> isValid = (word, num) => word.Sum(ch => (int)ch) >= num;

            string result = ReturnFirst(isValid, words, number);
            Console.WriteLine(result);
        }

        public static string ReturnFirst(Func<string, int, bool> isGreater, List<string> words, int number)
        {
            var word = words.FirstOrDefault(x => isGreater(x, number));
            return word;
        }
    }
}
