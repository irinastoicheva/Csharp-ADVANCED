namespace _7._Knight_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeMatrix, sizeMatrix];
            char[,] saveMatrix = new char[sizeMatrix, sizeMatrix];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] rowMatrix = Console.ReadLine().ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowMatrix[j];
                    saveMatrix[i, j] = rowMatrix[j];
                    if (rowMatrix[j] == 'K')
                    {
                        count++;
                    }
                }
            }

            for (int c = 0; c < count; c++)
            {
                int indexRow = -1;
                int indexCol = -1;
                int maxCounter = 0;
                int counter = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        counter = 0;
                        if (matrix[i, j] == 'K')
                        {
                            bool isTrue = GetIsTrue(matrix, i, 2, j, -1);
                            if (isTrue)
                            {
                                if (matrix[i + 2, j - 1] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, 2, j, +1);
                            if (isTrue)
                            {
                                if (matrix[i + 2, j + 1] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, +1, j, -2);
                            if (isTrue)
                            {
                                if (matrix[i + 1, j - 2] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, +1, j, +2);
                            if (isTrue)
                            {
                                if (matrix[i + 1, j + 2] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, -1, j, -2);
                            if (isTrue)
                            {
                                if (matrix[i - 1, j - 2] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, -1, j, +2);
                            if (isTrue)
                            {
                                if (matrix[i - 1, j + 2] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, -2, j, -1);
                            if (isTrue)
                            {
                                if (matrix[i - 2, j - 1] == 'K')
                                {
                                    counter++;
                                }
                            }

                            isTrue = GetIsTrue(matrix, i, -2, j, +1);
                            if (isTrue)
                            {
                                if (matrix[i - 2, j + 1] == 'K')
                                {
                                    counter++;
                                }
                            }
                        }
                        if (counter > maxCounter)
                        {
                            indexRow = i;
                            indexCol = j;
                            maxCounter = counter;
                        }
                    }
                }
                if (indexRow >= 0 && indexCol >= 0)
                {
                    matrix[indexRow, indexCol] = '0';
                }
            }

            count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] != saveMatrix[i,j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }

        private static bool GetIsTrue(char[,] matrix, int i, int v1, int j, int v2)
        {
            if (i + v1 < matrix.GetLength(0) && i + v1 >= 0 && j + v2 >= 0 && j + v2 < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

