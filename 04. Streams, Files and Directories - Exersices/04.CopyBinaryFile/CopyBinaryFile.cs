namespace _04.CopyBinaryFile
{
    using System;
    using System.IO;

    class CopyBinaryFile
    {
        public static void Main()
        {
            using (FileStream reader = new FileStream(@"Resources/copyMe.png", FileMode.Open))
            {
                byte[] buffer = new byte[1024*4];

                using (FileStream writer = new FileStream("Output.png", FileMode.Create))
                {
                    while (true)
                    {
                        int line = reader.Read(buffer, 0, buffer.Length);

                        if (line == 0)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, line);
                    }
                }
            }
        }
    }
}
