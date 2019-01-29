namespace _02._Line_Numbers
{
    using System;
    using System.IO;

    class Program
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"Resources\02. Line Numbers\Input.txt"))
            {
                using (var writer = new StreamWriter("Output.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        var line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        line = $"{counter}. {line}";
                        writer.WriteLine(line);
                        counter++;
                    }
                }
            }
        }
    }
}
