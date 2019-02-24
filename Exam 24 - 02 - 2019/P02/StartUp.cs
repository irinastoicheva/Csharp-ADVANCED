namespace P02
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[][] matrix = new char[number][];
            for (int i = 0; i < number; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int rowFirst = -1;
            int colFirst = -1;
            int rowSecond = -1;
            int colSecond = -1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0;j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'f')
                    {
                        rowFirst = i;
                        colFirst = j;
                    }

                    if (matrix[i][j] == 's')
                    {
                        rowSecond = i;
                        colSecond = j;
                    }
                }
            }

            while (true)
            {
                string[] commandLine = Console.ReadLine().Split();
                string firstCommand = commandLine[0];
                string secondCommand = commandLine[1];
                    switch (firstCommand)
                    {
                        case "up":
                            if (rowFirst > 0)
                            {
                                rowFirst--;
                            }
                            else
                            {
                                rowFirst = number - 1;
                            }
                            break;
                        case "down":
                            if (rowFirst < number - 1)
                            {
                                rowFirst++;
                            }
                            else
                            {
                                rowFirst = 0;
                            }
                            break;
                        case "left":
                            if (colFirst > 0)
                            {
                                colFirst--;
                            }
                            else
                            {
                                colFirst = matrix[0].Length - 1;
                            }
                            break;
                        case "right":
                            if (colFirst < matrix[0].Length - 1)
                            {
                                colFirst++;
                            }
                            else
                            {
                                colFirst = 0;
                            }
                            break;

                    }

                    if (matrix[rowFirst][colFirst] == '*')
                    {
                        matrix[rowFirst][colFirst] = 'f';
                    }
                    else if (matrix[rowFirst][colFirst] == 's')
                    {
                        matrix[rowFirst][colFirst] = 'x';
                        break;
                    }

                switch (secondCommand)
                {
                    case "up":
                        if (rowSecond > 0)
                        {
                            rowSecond--;
                        }
                        else
                        {
                            rowSecond = number - 1;
                        }
                        break;
                    case "down":
                        if (rowSecond < number - 1)
                        {
                            rowSecond++;
                        }
                        else
                        {
                            rowSecond = 0;
                        }
                        break;
                    case "left":
                        if (colSecond > 0)
                        {
                            colSecond--;
                        }
                        else
                        {
                            colSecond = matrix[0].Length - 1;
                        }
                        break;
                    case "right":
                        if (colSecond < matrix[0].Length - 1)
                        {
                            colSecond++;
                        }
                        else
                        {
                            colSecond = 0;
                        }
                        break;

                }

                if (matrix[rowSecond][colSecond] == '*')
                {
                    matrix[rowSecond][colSecond] = 's';
                }
                else if(matrix[rowSecond][colSecond] == 'f')
                {
                    matrix[rowSecond][colSecond] = 'x';
                    break;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }
}
