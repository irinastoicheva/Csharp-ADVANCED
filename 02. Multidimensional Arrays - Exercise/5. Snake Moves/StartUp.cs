namespace _5._Snake_Moves
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int[] sizeMatrix = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = sizeMatrix[0];
            int col = sizeMatrix[1];

            string snake = Console.ReadLine();
            Queue<char> sequence = new Queue<char>(snake);
            char[,] matrix = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = sequence.Peek();
                    sequence.Enqueue(sequence.Dequeue());
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
