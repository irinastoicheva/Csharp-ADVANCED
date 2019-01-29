namespace _3._1._Simple_Calculator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> inputLine = new Queue<string>(input);
            int sum = int.Parse(inputLine.Dequeue());

            while (inputLine.Count() > 0)
            {
                if (inputLine.Peek() == "+")
                {
                    inputLine.Dequeue();
                    sum += int.Parse(inputLine.Dequeue());
                }
                else if (inputLine.Peek() == "-")
                {
                    inputLine.Dequeue();
                    sum -= int.Parse(inputLine.Dequeue());
                }
            }

            Console.WriteLine(sum);
        }
    }
}
