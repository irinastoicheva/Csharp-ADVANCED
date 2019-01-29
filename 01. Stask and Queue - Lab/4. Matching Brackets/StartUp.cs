namespace _4._Matching_Brackets
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> numbersOfBrackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    numbersOfBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = numbersOfBrackets.Pop();
                    Console.WriteLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
