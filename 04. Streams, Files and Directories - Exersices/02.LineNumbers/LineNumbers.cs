namespace _02.LineNumbers
{
    using System;
    using System.Linq;
    using System.IO;

    class LineNumbers
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(@"Resources/TextInput.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Output.txt"))
                {
                    int counter = 1;

                    while (true)
                    {
                        string line = reader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        int symbolCount = 0;
                        int punctuationMarksCount = 0;

                        for (int i = 0; i < line.Length; i++)
                        {
                            char symbol = line[i];

                            if (symbol == ' ')
                            {

                            }
                            else if ((symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z'))
                            {
                                symbolCount++;
                            }
                            else
                            {
                                punctuationMarksCount++;
                            }
                        }

                        writer.WriteLine($"Line {counter}: {line} ({symbolCount})({punctuationMarksCount})");
                        counter++;
                    }
                }
            }
        }
    }
}
