namespace _03.Bombs
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowMatrix[j];
                }
            }

            int[] bombs = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < bombs.Length; i += 2)
            {
                int rowBomb = bombs[i];
                int colBomb = bombs[i + 1];
                int power;

                bool isValid = GetIsValid(matrix, rowBomb, colBomb);
                if (isValid)
                {
                    if (matrix[rowBomb, colBomb] > 0)
                    {
                        power = matrix[rowBomb, colBomb];

                        matrix[rowBomb, colBomb] = 0;

                        isValid = GetIsValid(matrix, rowBomb, 0, colBomb, -1);
                        if (isValid)
                        {
                            if (matrix[rowBomb, colBomb - 1] > 0)
                            {
                                matrix[rowBomb, colBomb - 1] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, -1, colBomb, -1);
                        if (isValid)
                        {
                            if (matrix[rowBomb - 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb - 1] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, -1, colBomb, 0);
                        if (isValid)
                        {
                            if (matrix[rowBomb - 1, colBomb] > 0)
                            {
                                matrix[rowBomb - 1, colBomb] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, -1, colBomb, +1);
                        if (isValid)
                        {
                            if (matrix[rowBomb - 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb - 1, colBomb + 1] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, 0, colBomb, +1);
                        if (isValid)
                        {
                            if (matrix[rowBomb, colBomb + 1] > 0)
                            {
                                matrix[rowBomb, colBomb + 1] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, +1, colBomb, +1);
                        if (isValid)
                        {
                            if (matrix[rowBomb + 1, colBomb + 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb + 1] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, +1, colBomb, 0);
                        if (isValid)
                        {
                            if (matrix[rowBomb + 1, colBomb] > 0)
                            {
                                matrix[rowBomb + 1, colBomb] -= power;
                            }
                        }

                        isValid = GetIsValid(matrix, rowBomb, +1, colBomb, -1);
                        if (isValid)
                        {
                            if (matrix[rowBomb + 1, colBomb - 1] > 0)
                            {
                                matrix[rowBomb + 1, colBomb - 1] -= power;
                            }
                        }
                    }
                }
            }

            int count = 0;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool GetIsValid(int[,] matrix, int rowBomb, int v1, int colBomb, int v2)
        {
            if (rowBomb + v1 >= 0 && rowBomb + v1 < matrix.GetLength(0) && colBomb + v2 >= 0 && colBomb + v2 < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool GetIsValid(int[,] matrix, int rowBomb, int colBomb)
        {
            if (rowBomb >= 0 && rowBomb < matrix.GetLength(0) && colBomb >= 0 && colBomb < matrix.GetLength(1))
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
