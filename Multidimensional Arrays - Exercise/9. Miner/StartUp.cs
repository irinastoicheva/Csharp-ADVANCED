namespace _9._Miner
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            string[] commandLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[sizeField, sizeField];
            int minerRow = -1;
            int minerCol = -1;
            int countCoal = 0;
            for (int i = 0; i < sizeField; i++)
            {
                char[] inputRow = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int j = 0; j < sizeField; j++)
                {
                    matrix[i, j] = inputRow[j];
                    if (matrix[i, j] == 's')
                    {
                        minerRow = i;
                        minerCol = j;
                        matrix[i, j] = '*';
                    }
                    else if (matrix[i,j] == 'c')
                    {
                        countCoal++;
                    }
                }
            }

            for (int i = 0; i < commandLine.Length; i++)
            {
                switch (commandLine[i])
                {
                    case "down":
                        if (minerRow + 1 < sizeField)
                        {
                            minerRow += 1;
                        }
                        break;
                    case "up":
                        if (minerRow - 1 >= 0)
                        {
                            minerRow -= 1;
                        }
                        break;
                    case "left":
                        if (minerCol - 1 >= 0)
                        {
                            minerCol -= 1;
                        }
                        break;
                    case "right":
                        if (minerCol + 1 < sizeField)
                        {
                            minerCol += 1;
                        }
                        break;
                }

                switch (matrix[minerRow, minerCol])
                {
                    case 'e':
                        Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                        return;
                    case 'c':
                        countCoal--;
                        matrix[minerRow, minerCol] = '*';
                        if (countCoal == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine($"{countCoal} coals left. ({minerRow}, {minerCol})");
        }
    }
}
