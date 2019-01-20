namespace _1._Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            Stack<char> stackOfChar = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                stackOfChar.Push(text[i]);
            }

            while (stackOfChar.Count > 0)
            {
                Console.Write(stackOfChar.Pop());
            }

            Console.WriteLine();
        }
    }
}
