namespace _05._Slice_File
{
    using System;
    using System.IO;
    using System.Text;

    class SliceFile
    {
        public static void Main()
        {
            int parts = int.Parse(Console.ReadLine());

            using (FileStream reader = new FileStream(@"Resources\05. Slice File\sliceMe.txt", FileMode.Open))
            {
                int sizesOfNewFiles = (int)Math.Ceiling(reader.Length / (double)parts);
                byte[] buffer = new byte[1024];

                for (int i = 1; i <= parts; i++)
                {
                    int currentRead = 0;

                    using (FileStream writer = new FileStream($"Par-{i}.txt", FileMode.Create))
                    {
                        while (true)
                        {
                            int line = reader.Read(buffer, 0, buffer.Length);

                            currentRead += line;

                            if (line == 0)
                            {
                                break;
                            }

                            writer.Write(buffer, 0, line);

                            if (currentRead >= sizesOfNewFiles)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
