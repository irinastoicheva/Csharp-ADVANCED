namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> previousText = new Stack<string>();

            for (int i = 0; i < number; i++)
            {
                string[] commandLine = Console.ReadLine().Split();
                string command = commandLine[0];

                if (command == "1")
                {
                    previousText.Push(text.ToString());
                    text.Append(commandLine[1]);
                }
                else if (command == "2")
                {
                    previousText.Push(text.ToString());
                    int countElements = int.Parse(commandLine[1]);
                    text.Remove(text.Length - countElements, countElements);
                }
                else if (command == "3")
                {
                    int indexElement = int.Parse(commandLine[1]) - 1;
                    Console.WriteLine(text.ToString()[indexElement]);
                }
                else if (command == "4")
                {
                    text.Clear();
                    text.Append(previousText.Pop());
                }
            }
        }
    }
}
