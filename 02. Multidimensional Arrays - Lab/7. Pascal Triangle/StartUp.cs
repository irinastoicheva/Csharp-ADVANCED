namespace _7._Pascal_Triangle
{
    using System;
    using System.Numerics;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                return;
            }
            BigInteger[][] jagged = new BigInteger[number][];

            for (int i = 0; i < number; i++)
            {
                jagged[i] = new BigInteger[i + 1];
                for (int j = 0; j < i + 1; j++)
                {
                    if (i == 0)
                    {
                        jagged[i][j] = 1;
                    }
                    else
                    {
                        if (j == 0)
                        {
                            jagged[i][j] = 1;
                        }
                        else
                        {
                            if (j < i)
                            {
                                jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
                            }
                            else
                            {
                                jagged[i][j] = 1;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write($"{jagged[i][j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
