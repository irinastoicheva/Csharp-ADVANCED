namespace _06._Folder_Size
{
    using System;
    using System.IO;

    class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");

            long sum = 0;
            int count = 0;

            foreach (var file in files)
            {
                count++;
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            File.WriteAllText("TestFolder/Output.txt", ((double)sum / 1024 / 1024).ToString());
        }
    }
}
