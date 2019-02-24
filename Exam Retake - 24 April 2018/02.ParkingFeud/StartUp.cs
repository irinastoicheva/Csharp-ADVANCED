namespace _02.ParkingFeud
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] sizeParking = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = sizeParking[0];
            int m = sizeParking[1];
            int inputSam = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n * 2 - 1, m + 2];
            int distance = 0;
            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string parkingSam = input[inputSam - 1];
                input.RemoveAt(inputSam - 1);

                if (!input.Contains(parkingSam))
                {
                    int row = (int.Parse(parkingSam[1].ToString()) + 2) / 2;
                    int col = (int)parkingSam[0] - 64;
                    int rowSam = 2 * inputSam - 1;
                    distance += GetDistance(row, col, rowSam, matrix.GetLength(1));

                    Console.WriteLine($"Parked successfully at {parkingSam}.");
                    Console.WriteLine($"Total Distance Passed: {distance}");
                    return;
                }
                else
                {
                    int indexOther = Array.IndexOf(input.ToArray(), parkingSam);
                    if (indexOther + 1 >= inputSam)
                    {
                        indexOther += 2;
                    }
                    else
                    {
                        indexOther++;
                    }
                    int row = (int.Parse(parkingSam[1].ToString()) * 2 - 2);
                    int col = (int)parkingSam[0] - 64;
                    int rowSam = 2 * inputSam - 1;
                    int rowOther = 2 * indexOther - 1;
                    int distanceSam = 0;
                    int distanceOther = 0;

                    distanceSam += GetDistance(row, col, rowSam, matrix.GetLength(1));

                    distanceOther += GetDistance(row, col, rowOther, matrix.GetLength(1));

                    if (distanceSam <= distanceOther)
                    {
                        distance += distanceSam;
                        Console.WriteLine($"Parked successfully at {parkingSam}.");
                        Console.WriteLine($"Total Distance Passed: {distance}");
                        return;
                    }
                    else
                    {
                        distance += 2 * distanceSam;
                    }
                }
            }
        }

        private static int GetDistance(int row, int col, int rowSam, int lenght)
        {
            if (Math.Abs(row - rowSam) /2 == 0)
            {
                return col;
            }
            else
            {
                if ((Math.Abs(rowSam - row) / 2 )% 2 == 0)
                {
                    return Math.Abs(rowSam - row) / 2 * lenght + col + Math.Abs(rowSam - col) / 2;
                }
                else
                {
                    return (Math.Abs(rowSam - row) / 2) * lenght + (lenght - col) + Math.Abs(rowSam - row) / 2;
                }
            }
        }
    }
}
