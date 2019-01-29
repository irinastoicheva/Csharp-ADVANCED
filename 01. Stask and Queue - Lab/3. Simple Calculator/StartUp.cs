namespace _3._Simple_Calculator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string line = Console.ReadLine();
            string[] arrayOfNumbers = line.Split(new char[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            string[] arrayOfSings = line.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<double> positiveNumbers = new Stack<double>();
            Stack<double> negativeNumbers = new Stack<double>();

            if (arrayOfNumbers.Length - 1 == arrayOfSings.Length)
            {
                double number = double.Parse(arrayOfNumbers[0]);
                positiveNumbers.Push(number);

                for (int i = 0; i < arrayOfSings.Length; i++)
                {
                    string sing = arrayOfSings[i];
                    number = double.Parse(arrayOfNumbers[i + 1]);

                    if (sing == "+")
                    {
                        positiveNumbers.Push(number);
                    }
                    else if (sing == "-")
                    {
                        negativeNumbers.Push(number);
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfSings.Length; i++)
                {
                    string sing = arrayOfSings[i];
                    double number = double.Parse(arrayOfNumbers[i]);

                    if (sing == "+")
                    {
                        positiveNumbers.Push(number);
                    }
                    else if (sing == "-")
                    {
                        negativeNumbers.Push(number);
                    }
                }
            }

            Console.WriteLine(positiveNumbers.ToArray().Sum() - negativeNumbers.ToArray().Sum());
        }
    }
}
