namespace _6._Bomb_the_Basement
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
            int[] bombParameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowBomb = bombParameters[0];
            int colBomb = bombParameters[1];
            int radiusBomb = bombParameters[2];

            int[,] matrix = new int[rowMatrix, colMatrix];

            int counter = 0;
            for (int i = rowBomb - radiusBomb; i <= rowBomb; i++)
            {
                if (i >= 0 && i < matrix.GetLength(0))
                {
                    for (int j = colBomb - counter; j <= colBomb + counter; j++)
                    {
                        if (j >= 0 && j < matrix.GetLength(1))
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }
                counter++;
            }

            counter = 0;
            for (int i = rowBomb; i <= rowBomb + radiusBomb; i++)
            {
                if (i >= 0 && i < matrix.GetLength(0))
                {
                    for (int j = colBomb - radiusBomb + counter; j <= colBomb + radiusBomb - counter; j++)
                    {
                        if (j >= 0 && j < matrix.GetLength(1))
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }
                counter++;
            }

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int i = matrix.GetLength(0) - 1; i > 0; i--)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 1 && matrix[i - 1, j] == 0)
                        {
                            matrix[i, j] = 0;
                            matrix[i - 1, j] = 1;
                        }
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
