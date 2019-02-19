namespace _03.Stack
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] commandLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandLine[0];
            CustomStack<string> customStak = new CustomStack<string>();
            while (command != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "Push":
                            string[] listInput = new string[commandLine.Length - 1];
                            for (int i = 0; i < listInput.Length; i++)
                            {
                                listInput[i] = commandLine[i + 1];
                            }

                            customStak.Push(listInput);
                            break;
                        case "Pop":
                            customStak.Pop();
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                commandLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                command = commandLine[0];
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in customStak)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
