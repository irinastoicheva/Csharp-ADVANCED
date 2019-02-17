namespace P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<string> headerRow = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[][] matrix = new string[number - 1][];

            for (int i = 0; i < number - 1; i++)
            {
                string[] rowInput = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                matrix[i] = rowInput;
            }
           
            string[] commandLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = commandLine[0];
            string header = commandLine[1];
            int index = headerRow.IndexOf(header);

            switch (command)
            {
                case "filter":
                    string value = commandLine[2];
                    int rowIndex = -1;

                    for (int i = 0; i < matrix.Length; i++)
                    {
                        if (matrix[i][index] == value)
                        {
                            rowIndex = i;
                        }
                    }
                    Console.WriteLine(string.Join(" | ", headerRow));
                    Console.WriteLine(string.Join(" | ", matrix[rowIndex]));
                    
                    break;

                case "hide":

                    headerRow.RemoveAt(index);
                    Console.WriteLine(string.Join(" | ", headerRow));
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[i].Where(x => x != header)));
                    }

                    break;

                case "sort":

                    Console.WriteLine(string.Join(" | ", headerRow));
                    foreach (var item in matrix.OrderBy(x => x[index]))
                    {
                        Console.WriteLine(string.Join(" | ", item));
                    }
                    break;
            }
        }
    }
}
