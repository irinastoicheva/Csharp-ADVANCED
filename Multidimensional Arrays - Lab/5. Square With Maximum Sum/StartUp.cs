namespace _5._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizeMatrix[0], sizeMatrix[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] elementsInCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elementsInCol[j];
                }
            }

            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        indexRow = i;
                        indexCol = j;
                    }
                }
            }

            for (int i = indexRow; i < indexRow + 2; i++)
            {
                for (int j = indexCol; j < indexCol + 2; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
