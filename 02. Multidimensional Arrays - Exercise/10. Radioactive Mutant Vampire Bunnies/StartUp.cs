namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsMatrix = sizeMatrix[0];
            int colsMatrix = sizeMatrix[1];
            char[,] matrix = new char[rowsMatrix, colsMatrix];
            int rowPlayer = -1;
            int colPlayer = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string rowInput = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowInput[j];
                    if (matrix[i, j] == 'P')
                    {
                        rowPlayer = i;
                        colPlayer = j;
                    }
                }
            }

            bool won = false;
            string commandLine = Console.ReadLine();
            for (int c = 0; c < commandLine.Length; c++)
            {
                if (won == false && matrix[rowPlayer, colPlayer] == 'B')
                {
                    break;
                }

                if (won)
                {
                    break;
                }

                matrix[rowPlayer, colPlayer] = '.';
                switch (commandLine[c])
                {
                    case 'U':
                        if (rowPlayer - 1 >= 0)
                        {
                            rowPlayer -= 1;
                        }
                        else
                        {
                            won = true;
                        }
                        break;
                    case 'D':
                        if (rowPlayer + 1 < matrix.GetLength(0))
                        {
                            rowPlayer += 1;
                        }
                        else
                        {
                            won = true;
                        }

                        break;
                    case 'L':
                        if (colPlayer - 1 >= 0)
                        {
                            colPlayer -= 1;
                        }
                        else
                        {
                            won = true;
                        }
                        break;
                    case 'R':
                        if (colPlayer + 1 < matrix.GetLength(1))
                        {
                            colPlayer += 1;
                        }
                        else
                        {
                            won = true;
                        }
                        break;
                }

                List<int> listOfBunnies = new List<int>();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 'B')
                        {
                            listOfBunnies.Add(i);
                            listOfBunnies.Add(j);
                        }
                    }
                }

                for (int b = 0; b < listOfBunnies.Count; b += 2)
                {
                    int i = listOfBunnies[b];
                    int j = listOfBunnies[b + 1];
                    if (matrix[i, j] == 'B')
                    {
                        if (i + 1 < matrix.GetLength(0))
                        {
                            matrix[i + 1, j] = 'B';
                        }
                        if (i - 1 >= 0)
                        {
                            matrix[i - 1, j] = 'B';
                        }
                        if (j + 1 < matrix.GetLength(1))
                        {
                            matrix[i, j + 1] = 'B';
                        }
                        if (j - 1 >= 0)
                        {
                            matrix[i, j - 1] = 'B';
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
            if (won)
            {
                Console.WriteLine($"won: {rowPlayer} {colPlayer}");
            }
            else
            {
                Console.WriteLine($"dead: {rowPlayer} {colPlayer}");
            }
        }
    }
}
