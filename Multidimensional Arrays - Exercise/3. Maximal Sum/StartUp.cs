namespace _3._Maximal_Sum
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

            int maxSum = int.MinValue;
            int indexRow = -1;
            int indexCol = -1;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2] + matrix[i, j + 1] + matrix[i, j + 2];
                    if ( sum > maxSum)
                    {
                        maxSum = sum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = indexRow; i < indexRow + 3; i++)
            {
                for (int j = indexCol; j < indexCol + 3; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
