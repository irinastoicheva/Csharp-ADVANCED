namespace _4._Matrix_shuffling
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowMatrix = sizeMatrix[0];
            int colMatrix = sizeMatrix[1];

            int[,] matrix = new int[rowMatrix, colMatrix];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputCol = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputCol[j];
                }
            }

            string[] commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandLine[0];
            while (command != "END")
            {
                if (command == "swap" && commandLine.Length == 5)
                {
                    int row1 = int.Parse(commandLine[1]);
                    int col1 = int.Parse(commandLine[2]);
                    int row2 = int.Parse(commandLine[3]);
                    int col2 = int.Parse(commandLine[4]);

                    if (row1 >= 0 && row1 < rowMatrix && row2 >= 0 && row2 < rowMatrix &&
                        col1 >= 0 && col1 < colMatrix && col2 >= 0 && col1 < colMatrix)
                    {
                        int saveNumber = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = saveNumber;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write(matrix[i, j] + " ");
                            }

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                commandLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                command = commandLine[0];
            }
        }
    }
}
