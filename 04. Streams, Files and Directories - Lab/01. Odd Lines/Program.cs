namespace _01._Odd_Lines
{
    using System;
    using System.IO;

    class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"Resources\01. Odd Lines\Input.txt"))
            {
                int counter = 0;
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    counter++;
                }
            }
        }
    }
}
