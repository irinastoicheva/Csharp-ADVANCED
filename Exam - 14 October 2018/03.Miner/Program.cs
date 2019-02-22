namespace _03.Miner
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            string[][] matrix = new string[number][];

            int row = -1;
            int col = -1;
            for (int i = 0; i < matrix.Length; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                matrix[i] = input;
                
                if (matrix[i].Contains("s"))
                {
                    row = i;
                    col = Array.IndexOf(matrix[i], "s");
                }
            }

            int countCoal = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i][j] == "c")
                    {
                        countCoal++;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "up": 
                        if (row == 0)
                        {
                            continue;
                        }
                        row--; break;
                    case "down":
                        if (row == matrix.Length - 1)
                        {
                            continue;
                        }
                        row++; break;
                    case "left":
                        if (col == 0)
                        {
                            continue;
                        }
                        col--; break;
                    case "right":
                        if (col == matrix.Length - 1)
                        {
                            continue;
                        }
                        col++; break;
                }

                switch (matrix[row][col])
                {
                    case "c": countCoal--; matrix[row][col] = "*";
                        if (countCoal == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({row}, {col})");
                            return;
                        }
                        break;
                    case "e": Console.WriteLine($"Game over! ({row}, {col})"); return;
                }
            }

            Console.WriteLine($"{countCoal} coals left. ({row}, {col})");
        }
    }
}
