namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> sequence = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    sequence.Push(input[i]);
                }
                else if (input[i] == ')' && sequence.Any())
                {
                    if (sequence.Peek() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        sequence.Pop();
                    }
                }
                else if (input[i] == ']' && sequence.Any())
                {
                    if (sequence.Peek() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        sequence.Pop();
                    }
                }
                else if (input[i] == '}' && sequence.Any())
                {
                    if (sequence.Peek() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    else
                    {
                        sequence.Pop();
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
