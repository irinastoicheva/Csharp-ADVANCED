namespace _01._Even_Lines
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class EvenLines
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(@"Resource/Text.txt"))
            {
                int counter = 0;

                while (true)
                {
                    string readLine = reader.ReadLine();

                    if (readLine == null)
                    {
                        break;
                    }

                    List<string> words = new List<string>();
                    StringBuilder sb = new StringBuilder();

                    if (counter % 2 == 0)
                    {
                        for (int i = 0; i < readLine.Length; i++)
                        {
                            if (readLine[i] == '.' || readLine[i] == ',' || readLine[i] == '-' || readLine[i] == '!' || readLine[i] == '?')
                            {
                                sb.Append("@");
                            }
                            else if (readLine[i] == ' ')
                            {
                                words.Add(sb.ToString());
                                sb.Clear();
                            }
                            else
                            {
                                sb.Append(readLine[i]);
                            }
                        }
                        words.Add(sb.ToString());

                        words.Reverse();
                        Console.WriteLine(string.Join(" ", words));
                    }

                    counter++;
                }
            }
        }
    }
}
