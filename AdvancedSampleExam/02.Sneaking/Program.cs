namespace _02.Sneaking
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[][] matrix = new char[number][];
            int rowSam = -1;
            int colSam = -1;

            for (int i = 0; i < number; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                if (matrix[i].Contains('S'))
                {
                    rowSam = i;
                    colSam = Array.IndexOf(matrix[i], 'S');
                }
            }

            matrix[rowSam][colSam] = '.';

            char[] moves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < moves.Length; i++)
            {
                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row].Contains('b'))
                    {
                        int colB = Array.IndexOf(matrix[row], 'b');
                        if (colB == matrix[row].Length - 1)
                        {
                            matrix[row][colB] = 'd';
                        }
                        else
                        {
                            matrix[row][colB] = '.';
                            matrix[row][colB + 1] = 'b';
                        }
                    }
                    else if (matrix[row].Contains('d'))
                    {
                        int colD = Array.IndexOf(matrix[row], 'd');
                        if (colD == 0)
                        {
                            matrix[row][colD] = 'b';
                        }
                        else
                        {
                            matrix[row][colD] = '.';
                            matrix[row][colD - 1] = 'd';
                        }
                    }
                }
                if (matrix[rowSam].Contains('b'))
                {
                    int colB = Array.IndexOf(matrix[rowSam], 'b');
                    if (colB < colSam)
                    {
                        Console.WriteLine($"Sam died at {rowSam}, {colSam}");
                        matrix[rowSam][colSam] = 'X';
                        break;
                    }
                }
                else if (matrix[rowSam].Contains('d'))
                {
                    int colD = Array.IndexOf(matrix[rowSam], 'd');
                    if (colD > colSam)
                    {
                        Console.WriteLine($"Sam died at {rowSam}, {colSam}");
                        matrix[rowSam][colSam] = 'X';
                        break;
                    }
                }

                switch (moves[i])
                {
                    case 'U': rowSam--; break;
                    case 'D': rowSam++; break;
                    case 'L': colSam--; break;
                    case 'R': colSam++; break;
                }

                if (matrix[rowSam].Contains('N'))
                {
                    int colN = Array.IndexOf(matrix[rowSam], 'N');
                    matrix[rowSam][colN] = 'X';
                    matrix[rowSam][colSam] = 'S';
                    Console.WriteLine("Nikoladze killed!");
                    break;
                }
                if (matrix[rowSam][colSam] == 'b' || matrix[rowSam][colSam] == 'd')
                {
                    matrix[rowSam][colSam] = '.';
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }
}
