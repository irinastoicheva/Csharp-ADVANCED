namespace _03._Word_Count
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class Program
    {
        public static void Main()
        {
            char[] buffer = new char[4];
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(@"Resources\03. Word Count\words.txt"))
            {
                while (true)
                {
                    int total = reader.Read(buffer, 0, buffer.Length);

                    if (total == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < total; i++)
                    {
                        sb.Append(buffer[i]);
                    }
                }
            }

            string[] words = sb.ToString().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            sb.Clear();

            using (StreamReader reader = new StreamReader(@"Resources\03. Word Count\text.txt"))
            {
                while (true)
                {
                    int total = reader.Read(buffer, 0, buffer.Length);

                    if (total == 0)
                    {
                        break;
                    }

                    for (int i = 0; i < total; i++)
                    {
                        sb.Append(buffer[i]);
                    }
                }
            }

            string[] wordsInText = sb.ToString().Split(new[]{' ', ',', '-', '.', '!', '?', ':'}, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> listOfWords = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!listOfWords.ContainsKey(words[i]))
                {
                    listOfWords[words[i].ToLower()] = 0;
                }

                for (int j = 0; j < wordsInText.Length; j++)
                {
                    if (words[i] == wordsInText[j].ToLower())
                    {
                        listOfWords[words[i]]++;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("Output.txt"))
            {
                foreach (var item in listOfWords.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
