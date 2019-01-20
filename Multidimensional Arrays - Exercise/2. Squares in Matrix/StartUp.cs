namespace _2._Squares_in_Matrix
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split(new [] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowMatrix = sizeMatrix[0];
            int colMatrix = sizeMatrix[1];

            char[,] matrix = new char[rowMatrix, colMatrix];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] inputCol = Console.ReadLine().Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j= 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputCol[j];
                }
            }

            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i,j] == matrix[i+1,j] && matrix[i,j] == matrix[i,j+1] && matrix[i+1,j] == matrix[i+1,j+1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
