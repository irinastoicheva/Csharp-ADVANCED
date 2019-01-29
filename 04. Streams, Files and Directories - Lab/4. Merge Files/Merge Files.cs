namespace _04._Merge_Files
{
    using System;
    using System.IO;

    class MergeFiles
    {
        public static void Main()
        {
            using (StreamReader readerFirstFile = new StreamReader(@"Resources\04. Merge Files\FileOne.txt"))
            {
                using (StreamReader readerSecondFile = new StreamReader(@"Resources\04. Merge Files\FileTwo.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("Output.txt"))
                    {
                        while (true)
                        {
                            string firstLine = readerFirstFile.ReadLine();
                            string secondLine = readerSecondFile.ReadLine();

                            if (firstLine == null && secondLine == null)
                            {
                                break;
                            }

                            if (firstLine != null)
                            {
                                writer.WriteLine(firstLine);
                            }

                            if (secondLine != null)
                            {
                                writer.WriteLine(secondLine);
                            }
                        }
                    }
                }
            }
        }
    }
}
