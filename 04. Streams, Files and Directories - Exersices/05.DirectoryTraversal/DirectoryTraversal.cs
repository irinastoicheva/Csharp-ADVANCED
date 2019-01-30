namespace _05.DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class DirectoryTraversal
    {
        public static void Main()
        {
            string path = Console.ReadLine();

            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);

            Dictionary<string, List<FileInfo>> listOfFiles = new Dictionary<string, List<FileInfo>>();

            foreach (var file in files)
            {
                FileInfo info = new FileInfo(file);

                if (!listOfFiles.ContainsKey(info.Extension))
                {
                    listOfFiles[info.Extension] = new List<FileInfo>();
                }

                listOfFiles[info.Extension].Add(info);
            }

            using (StreamWriter writer = new StreamWriter("report.txt"))
            {
                foreach (var kvp in listOfFiles.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
                {
                    writer.WriteLine(kvp.Key);

                    foreach (var item in kvp.Value.OrderBy(x => x.Length))
                    {
                        writer.WriteLine($"--{item.Name} - {item.Length*1.0 / 1024*1.0:F3}kb");
                    }
                }
            }
        }
    }
}
