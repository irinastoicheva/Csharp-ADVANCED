namespace _02.Collection
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstCommand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] list = new string[firstCommand.Length - 1];

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = firstCommand[i + 1];
            }

            ListyIterator<string> listyIterator = new ListyIterator<string>(list);

            string command = Console.ReadLine();
            while (command != "END")
            {
                switch (command)
                {
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        Console.WriteLine(listyIterator.Print());
                        break;
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "PrintAll":
                        Console.WriteLine(listyIterator.PrintAll());
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
